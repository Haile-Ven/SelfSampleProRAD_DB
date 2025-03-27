using SelfSampleProRAD_DB.DTOs;
using SelfSampleProRAD_DB_SQL.Controllers;
using SelfSampleProRAD_DB_SQL.DB;
using SelfSampleProRAD_DB_SQL.Models;

namespace SelfSampleProRAD_DB.Controller
{
    class TasksController
    {
        public (EmployeeTasks,string,bool) AssignTask(string tskNm, Guid aTo, Guid aBy)
        {
            try
            {
                // Create the Tasks model instance
                var task = new Tasks
                {
                    TaskName = tskNm,
                    Status = 'P'
                };

                // Create the EmployeeTasks model instance
                var employeeTask = new EmployeeTasks
                {
                    TaskId = task.TaskId,
                    AssignedToId = aTo,
                    AssignedById = aBy
                };

                using (SqlConnection connection = new DBConnection().openConnection())
                {
                    SqlTransaction transaction = connection.BeginTransaction();
                    
                    try
                    {
                        // Insert task
                        string taskSql = "INSERT INTO Tasks (TaskId, TaskName, Status) VALUES (@TaskId, @TaskName, @Status)";
                        
                        using (SqlCommand taskCommand = new SqlCommand(taskSql, connection, transaction))
                        {
                            taskCommand.Parameters.AddWithValue("@TaskId", task.TaskId);
                            taskCommand.Parameters.AddWithValue("@TaskName", task.TaskName);
                            taskCommand.Parameters.AddWithValue("@Status", task.Status);
                            taskCommand.ExecuteNonQuery();
                        }
                        
                        // Insert employee task
                        string employeeTaskSql = "INSERT INTO EmployeeTasks (ETID, TaskId, AssignedToId, AssignedById) VALUES (@ETID, @TaskId, @AssignedToId, @AssignedById)";
                        
                        using (SqlCommand employeeTaskCommand = new SqlCommand(employeeTaskSql, connection, transaction))
                        {
                            employeeTaskCommand.Parameters.AddWithValue("@ETID", employeeTask.ETID);
                            employeeTaskCommand.Parameters.AddWithValue("@TaskId", employeeTask.TaskId);
                            employeeTaskCommand.Parameters.AddWithValue("@AssignedToId", employeeTask.AssignedToId);
                            employeeTaskCommand.Parameters.AddWithValue("@AssignedById", employeeTask.AssignedById);
                            employeeTaskCommand.ExecuteNonQuery();
                        }
                        
                        transaction.Commit();
                        return (employeeTask, "Task Successfully assigned", true);
                    }
                    catch (Exception ex)
                    {
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

        private static string GetStatusText(char status)
        {
            if (status == 'P') return "Pending";
            if (status == 'S') return "Started";
            if (status == 'C') return "Completed";
            return "Unknown";
        }

        public (List<TaskViewToResponseDTO>, string) ViewTasksFor(Guid taskTo)
        {
            try
            {
                var tasks = new List<TaskViewToResponseDTO>();
                
                using (SqlConnection connection = new DBConnection().openConnection())
                {
                    string query = @"SELECT t.TaskId, e.FirstName, e.LastName, t.TaskName, t.Status 
                                   FROM EmployeeTasks et 
                                   INNER JOIN Tasks t ON et.TaskId = t.TaskId 
                                   INNER JOIN Employee e ON et.AssignedById = e.EmployeeId 
                                   WHERE et.AssignedToId = @AssignedToId AND t.Status != 'C'";
                    
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@AssignedToId", taskTo);
                        
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                tasks.Add(new TaskViewToResponseDTO
                                {
                                    TaskId = (Guid)reader["TaskId"],
                                    FirstName = reader["FirstName"].ToString(),
                                    LastName = reader["LastName"].ToString(),
                                    TaskName = reader["TaskName"].ToString(),
                                    Status = GetStatusText(Convert.ToChar(reader["Status"]))
                                });
                            }
                        }
                    }
                }
                
                return (tasks, "Success");
            }
            catch (Exception ex)
            {
                return (null, "Error: " + (ex.InnerException?.Message ?? ex.Message));
            }
        }

        public (List<TaskViewByResponseDTO>, string) ViewTasksBy(Guid taskBy)
        {
            try
            {
                var tasks = new List<TaskViewByResponseDTO>();
                
                using (SqlConnection connection = new DBConnection().openConnection())
                {
                    string query = @"SELECT e.FirstName, e.LastName, t.TaskName, t.Status 
                                   FROM EmployeeTasks et 
                                   INNER JOIN Tasks t ON et.TaskId = t.TaskId 
                                   INNER JOIN Employee e ON et.AssignedToId = e.EmployeeId 
                                   WHERE et.AssignedById = @AssignedById";
                    
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@AssignedById", taskBy);
                        
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                tasks.Add(new TaskViewByResponseDTO
                                {
                                    FullName = $"{reader["FirstName"]} {reader["LastName"]}",
                                    TaskName = reader["TaskName"].ToString(),
                                    Status = GetStatusText(Convert.ToChar(reader["Status"]))
                                });
                            }
                        }
                    }
                }
                
                return (tasks, "Success");
            }
            catch (Exception ex)
            {
                return (null, "Error: " + (ex.InnerException?.Message ?? ex.Message));
            }
        }

        public (string, bool) startWorking(Guid taskID)
        {
            try
            {
                using (SqlConnection connection = new DBConnection().openConnection())
                {
                    // First check if task exists and its status
                    string checkQuery = "SELECT Status FROM Tasks WHERE TaskId = @TaskId";
                    char? currentStatus = null;
                    
                    using (SqlCommand checkCommand = new SqlCommand(checkQuery, connection))
                    {
                        checkCommand.Parameters.AddWithValue("@TaskId", taskID);
                        var result = checkCommand.ExecuteScalar();
                        
                        if (result == null || result == DBNull.Value)
                            return ("Task not found.", false);
                            
                        currentStatus = Convert.ToChar(result);
                    }
                    
                    // Check if task is already completed
                    if (currentStatus == 'C')
                        return ("Task is already completed.", false);
                        
                    // Update task status
                    string updateQuery = "UPDATE Tasks SET Status = 'S' WHERE TaskId = @TaskId";
                    
                    using (SqlCommand updateCommand = new SqlCommand(updateQuery, connection))
                    {
                        updateCommand.Parameters.AddWithValue("@TaskId", taskID);
                        updateCommand.ExecuteNonQuery();
                    }
                }
                
                return ("Task started.", true);
            }
            catch (Exception ex)
            {
                return ("Error: " + ex.Message, false);
            }
        }

        public (string,bool) submitWork(Guid taskID)
        {
            try
            {
                using (SqlConnection connection = new DBConnection().openConnection())
                {
                    // First check if task exists and its status
                    string checkQuery = "SELECT Status FROM Tasks WHERE TaskId = @TaskId";
                    char? currentStatus = null;
                    
                    using (SqlCommand checkCommand = new SqlCommand(checkQuery, connection))
                    {
                        checkCommand.Parameters.AddWithValue("@TaskId", taskID);
                        var result = checkCommand.ExecuteScalar();
                        
                        if (result == null || result == DBNull.Value)
                            return ("Task not found.", false);
                            
                        currentStatus = Convert.ToChar(result);
                    }
                    
                    // Check if task is already completed
                    if (currentStatus == 'C')
                        return ("Task is already completed.", false);
                        
                    // Update task status
                    string updateQuery = "UPDATE Tasks SET Status = 'C' WHERE TaskId = @TaskId";
                    
                    using (SqlCommand updateCommand = new SqlCommand(updateQuery, connection))
                    {
                        updateCommand.Parameters.AddWithValue("@TaskId", taskID);
                        updateCommand.ExecuteNonQuery();
                    }
                }
                
                return ("Task completed.", true);
            }
            catch (Exception ex)
            {
                return ("Error: " + ex.Message, false);
            }
        }
    }
}
