using SelfSampleProRAD_DB_SQL.DB;
using SelfSampleProRAD_DB_SQL.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SelfSampleProRAD_DB_SQL.Controllers
{
    internal class TaskController
    {
        // Helper method to convert status character to text description
        private static string GetStatusText(char status)
        {
            if (status == 'P') return "Pending";
            if (status == 'S') return "Started";
            if (status == 'C') return "Completed";
            if (status == 'U') return "Unstarted";
            return "Unknown";
        }

        // Assign a task to an employee
        public (Tasks, string, bool) AssignTask(string taskName, Guid assignedToId, Guid assignedById)
        {
            Tasks task = new Tasks();
            
            try
            {
                using (SqlConnection con = new DBConnection().openConnection())
                {
                    // Begin transaction
                    SqlTransaction transaction = con.BeginTransaction();
                    
                    try
                    {
                        // Insert into Tasks table
                        string taskSql = "INSERT INTO Tasks (TaskName, Status) OUTPUT INSERTED.TaskId VALUES (@TaskName, 'P')";
                        SqlCommand taskCmd = new SqlCommand(taskSql, con, transaction);
                        taskCmd.Parameters.AddWithValue("@TaskName", taskName);
                        
                        // Get the inserted TaskId
                        int taskId = (int)taskCmd.ExecuteScalar();
                        
                        // Insert into EmployeeTasks table
                        string empTaskSql = "INSERT INTO EmployeeTasks (TaskId, AssignedToId, AssignedById) VALUES (@TaskId, @AssignedToId, @AssignedById)";
                        SqlCommand empTaskCmd = new SqlCommand(empTaskSql, con, transaction);
                        empTaskCmd.Parameters.AddWithValue("@TaskId", taskId);
                        empTaskCmd.Parameters.AddWithValue("@AssignedToId", assignedToId);
                        empTaskCmd.Parameters.AddWithValue("@AssignedById", assignedById);
                        empTaskCmd.ExecuteNonQuery();
                        
                        // Commit transaction
                        transaction.Commit();
                        
                        // Set task properties
                        task.TaskId = taskId;
                        task.TaskName = taskName;
                        task.Status = 'P';
                        
                        return (task, "Task successfully assigned", true);
                    }
                    catch (Exception ex)
                    {
                        // Rollback transaction on error
                        transaction.Rollback();
                        return (null, "Error: " + ex.Message, false);
                    }
                }
            }
            catch (Exception ex)
            {
                return (null, "Error: " + ex.Message, false);
            }
        }

        // View tasks assigned to an employee
        public (List<Tasks>, string, bool) ViewTasksFor(Guid assignedToId)
        {
            List<Tasks> tasks = new List<Tasks>();
            
            try
            {
                using (SqlConnection con = new DBConnection().openConnection())
                {
                    string sql = @"SELECT t.TaskId, t.TaskName, t.Status, 
                                  e1.FirstName + ' ' + e1.LastName AS AssignedBy,
                                  e2.FirstName + ' ' + e2.LastName AS AssignedTo
                                  FROM Tasks t
                                  INNER JOIN EmployeeTasks et ON t.TaskId = et.TaskId
                                  INNER JOIN Employee e1 ON et.AssignedById = e1.EmployeeId
                                  INNER JOIN Employee e2 ON et.AssignedToId = e2.EmployeeId
                                  WHERE et.AssignedToId = @AssignedToId AND t.Status != 'C'";
                    
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@AssignedToId", assignedToId);
                    
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Tasks task = new Tasks
                            {
                                TaskId = reader.GetInt32(reader.GetOrdinal("TaskId")),
                                TaskName = reader.GetString(reader.GetOrdinal("TaskName")),
                                Status = reader.GetString(reader.GetOrdinal("Status"))[0],
                                AssignedBy = reader.GetString(reader.GetOrdinal("AssignedBy")),
                                AssignedTo = reader.GetString(reader.GetOrdinal("AssignedTo"))
                            };
                            
                            tasks.Add(task);
                        }
                    }
                }
                
                return (tasks, "Success", true);
            }
            catch (Exception ex)
            {
                return (null, "Error: " + ex.Message, false);
            }
        }

        // View tasks assigned by an employee
        public (List<Tasks>, string, bool) ViewTasksBy(Guid assignedById)
        {
            List<Tasks> tasks = new List<Tasks>();
            
            try
            {
                using (SqlConnection con = new DBConnection().openConnection())
                {
                    string sql = @"SELECT t.TaskId, t.TaskName, t.Status, 
                                  e1.FirstName + ' ' + e1.LastName AS AssignedBy,
                                  e2.FirstName + ' ' + e2.LastName AS AssignedTo
                                  FROM Tasks t
                                  INNER JOIN EmployeeTasks et ON t.TaskId = et.TaskId
                                  INNER JOIN Employee e1 ON et.AssignedById = e1.EmployeeId
                                  INNER JOIN Employee e2 ON et.AssignedToId = e2.EmployeeId
                                  WHERE et.AssignedById = @AssignedById";
                    
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@AssignedById", assignedById);
                    
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Tasks task = new Tasks
                            {
                                TaskId = reader.GetInt32(reader.GetOrdinal("TaskId")),
                                TaskName = reader.GetString(reader.GetOrdinal("TaskName")),
                                Status = reader.GetString(reader.GetOrdinal("Status"))[0],
                                AssignedBy = reader.GetString(reader.GetOrdinal("AssignedBy")),
                                AssignedTo = reader.GetString(reader.GetOrdinal("AssignedTo"))
                            };
                            
                            tasks.Add(task);
                        }
                    }
                }
                
                return (tasks, "Success", true);
            }
            catch (Exception ex)
            {
                return (null, "Error: " + ex.Message, false);
            }
        }

        // Start working on a task
        public (string, bool) StartWorking(int taskId)
        {
            try
            {
                using (SqlConnection con = new DBConnection().openConnection())
                {
                    // First check if task exists and is not completed
                    string checkSql = "SELECT Status FROM Tasks WHERE TaskId = @TaskId";
                    SqlCommand checkCmd = new SqlCommand(checkSql, con);
                    checkCmd.Parameters.AddWithValue("@TaskId", taskId);
                    
                    object result = checkCmd.ExecuteScalar();
                    if (result == null)
                    {
                        return ("Task not found.", false);
                    }
                    
                    char status = result.ToString()[0];
                    if (status == 'C')
                    {
                        return ("Task is already completed.", false);
                    }
                    
                    // Update task status to Started
                    string updateSql = "UPDATE Tasks SET Status = 'S' WHERE TaskId = @TaskId";
                    SqlCommand updateCmd = new SqlCommand(updateSql, con);
                    updateCmd.Parameters.AddWithValue("@TaskId", taskId);
                    updateCmd.ExecuteNonQuery();
                    
                    return ("Task started.", true);
                }
            }
            catch (Exception ex)
            {
                return ("Error: " + ex.Message, false);
            }
        }

        // Submit work for a task (mark as completed)
        public (string, bool) SubmitWork(int taskId)
        {
            try
            {
                using (SqlConnection con = new DBConnection().openConnection())
                {
                    // First check if task exists and is not completed
                    string checkSql = "SELECT Status FROM Tasks WHERE TaskId = @TaskId";
                    SqlCommand checkCmd = new SqlCommand(checkSql, con);
                    checkCmd.Parameters.AddWithValue("@TaskId", taskId);
                    
                    object result = checkCmd.ExecuteScalar();
                    if (result == null)
                    {
                        return ("Task not found.", false);
                    }
                    
                    char status = result.ToString()[0];
                    if (status == 'C')
                    {
                        return ("Task is already completed.", false);
                    }
                    
                    // Update task status to Completed
                    string updateSql = "UPDATE Tasks SET Status = 'C' WHERE TaskId = @TaskId";
                    SqlCommand updateCmd = new SqlCommand(updateSql, con);
                    updateCmd.Parameters.AddWithValue("@TaskId", taskId);
                    updateCmd.ExecuteNonQuery();
                    
                    return ("Task completed.", true);
                }
            }
            catch (Exception ex)
            {
                return ("Error: " + ex.Message, false);
            }
        }
    }
}
