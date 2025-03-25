using SelfSampleProRAD_DB_SQL.DB;
using SelfSampleProRAD_DB_SQL.Models;
using System.Collections.Generic;
namespace SelfSampleProRAD_DB_SQL.Controllers
{
    internal class AccountController
    {
        public (string, string, bool) ChangePassword(Guid UserId, string oldPass, string newPass)
        {
            using (SqlConnection con = new DBConnection().openConnection())
            {
                string oldPassDB = string.Empty;
                try
                {
                    var cksql = "SELECT Password FROM Account WHERE UserID = @UserID";
                    SqlCommand ckcmd = new SqlCommand(cksql, con);
                    ckcmd.Parameters.AddWithValue("@UserID", UserId);
                    oldPassDB = ckcmd.ExecuteScalar().ToString();
                }
                catch (Exception dbEx) 
                {
                    return (dbEx.Message, "Failed to change password.", false);
                }
               
                if (oldPass == oldPassDB)
                {
                    if(oldPass == newPass)
                    {
                        return ("New password must be different from old password.", "Failed to change password.", false);
                    }
                    try
                    {
                        string sql = "UPDATE Account SET Password = @Password WHERE UserID = @UserID";
                        SqlCommand cmd = new SqlCommand(sql, con);
                        cmd.Parameters.AddWithValue("@UserID", UserId);
                        cmd.Parameters.AddWithValue("@Password", newPass);
                        if(cmd.ExecuteNonQuery() > 0)
                        {
                            return ("Password changed successfully.", "Password changed successfully.", true);
                        }
                        
                        return ("Failed to change password.", "Failed to change password.", false);
                    }
                    catch (Exception dbEx) { return (dbEx.Message, "Failed to change password.", false); }
                }
                return ("Old password is incorrect.", "Failed to change password.", false);
            }
        }
        public (List<Account>, string, bool) ListAllAccounts()
        {
            List<Account> accounts = new List<Account>();
            
            try
            {
                using (SqlConnection con = new DBConnection().openConnection())
                {
                    string sql = "SELECT * FROM Account";
                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Account account = new Account
                                {
                                    UserID = reader.GetGuid(reader.GetOrdinal("UserId")),
                                    UserName = reader.GetString(reader.GetOrdinal("UserName")),
                                    Password = reader.GetString(reader.GetOrdinal("Password")),
                                    Status = reader.GetString(reader.GetOrdinal("Status"))[0]
                                };
                                
                                accounts.Add(account);
                            }
                        }
                    }
                }
                
                return (accounts, $"{accounts.Count} accounts retrieved successfully.", true);
            }
            catch (Exception ex)
            {
                return (null, $"Error retrieving accounts: {ex.Message}", false);
            }
        }

        public (List<Account>, string, bool) ListAllDevs()
        {
            List<Account> accounts = new List<Account>();
            
            try
            {
                using (SqlConnection con = new DBConnection().openConnection())
                {
                    string sql = "SELECT * FROM Account WHERE Username LIKE '%Developer%'";
                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Account account = new Account
                                {
                                    UserID = reader.GetGuid(reader.GetOrdinal("UserId")),
                                    UserName = reader.GetString(reader.GetOrdinal("UserName")),
                                    Password = reader.GetString(reader.GetOrdinal("Password")),
                                    Status = reader.GetString(reader.GetOrdinal("Status"))[0]
                                };
                                
                                accounts.Add(account);
                            }
                        }
                    }
                }
                
                return (accounts, $"{accounts.Count} developer accounts retrieved successfully.", true);
            }
            catch (Exception ex)
            {
                return (null, $"Error retrieving developer accounts: {ex.Message}", false);
            }
        }

        public (bool, string, bool) ToggleAccountStatus(string username, char newStatus)
        {
            try
            {
                // Validate the status parameter
                if (newStatus != 'A' && newStatus != 'D')
                {
                    return (false, "Invalid status. Status must be 'A' for active or 'D' for deactivated.", false);
                }
                
                string statusText = newStatus == 'A' ? "activated" : "deactivated";
                string statusColor = newStatus == 'A' ? "Forest Green" : "Tomato Red";
                
                using (SqlConnection con = new DBConnection().openConnection())
                {
                    string sql = "UPDATE Account SET Status = @Status WHERE Username = @Username";
                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@Username", username);
                        cmd.Parameters.AddWithValue("@Status", newStatus.ToString());
                        int rowsAffected = cmd.ExecuteNonQuery();
                        
                        if (rowsAffected > 0)
                        {
                            return (true, $"Account '{username}' has been {statusText} successfully.", true);
                        }
                        else
                        {
                            return (false, $"Account '{username}' not found or already {statusText}.", false);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                return (false, $"Error changing account status: {ex.Message}", false);
            }
        }

        /// <summary>
        /// Gets an Account with its associated Employee loaded
        /// </summary>
        public (Account, string, bool) GetAccountWithEmployee(Guid userId)
        {
            Account account = null;
            
            try
            {
                using (SqlConnection con = new DBConnection().openConnection())
                {
                    // First, get the account
                    string accountSql = "SELECT * FROM Account WHERE UserId = @UserId";
                    using (SqlCommand cmd = new SqlCommand(accountSql, con))
                    {
                        cmd.Parameters.AddWithValue("@UserId", userId);
                        
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                account = new Account
                                {
                                    UserID = reader.GetGuid(reader.GetOrdinal("UserId")),
                                    UserName = reader.GetString(reader.GetOrdinal("UserName")),
                                    Password = reader.GetString(reader.GetOrdinal("Password")),
                                    Status = reader.GetString(reader.GetOrdinal("Status"))[0]
                                };
                            }
                            else
                            {
                                return (null, "Account not found.", false);
                            }
                        }
                    }
                    
                    // If account exists, get the associated employee
                    if (account != null)
                    {
                        string employeeSql = "SELECT * FROM Employee WHERE UserId = @UserId";
                        using (SqlCommand cmd = new SqlCommand(employeeSql, con))
                        {
                            cmd.Parameters.AddWithValue("@UserId", account.UserID);
                            
                            using (SqlDataReader reader = cmd.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    account.Employee = new Employee
                                    {
                                        EmployeeId = reader.GetGuid(reader.GetOrdinal("EmployeeId")),
                                        FirstName = reader.GetString(reader.GetOrdinal("FirstName")),
                                        LastName = reader.GetString(reader.GetOrdinal("LastName")),
                                        Gender = reader.GetString(reader.GetOrdinal("Gender"))[0],
                                        Age = reader.GetByte(reader.GetOrdinal("Age")),
                                        Position = reader.GetString(reader.GetOrdinal("Position")),
                                        Category = reader.GetString(reader.GetOrdinal("Category")),
                                        Salary = (float)reader.GetDouble(reader.GetOrdinal("Salary")),
                                        Tax = (float)reader.GetDouble(reader.GetOrdinal("Tax")),
                                        UserId = account.UserID
                                    };
                                    
                                    // Set the back-reference to complete the navigation
                                    account.Employee.Account = account;
                                    return (account, "Account and employee retrieved successfully.", true);
                                }
                                else
                                {
                                    return (account, "Account found but no associated employee exists.", true);
                                }
                            }
                        }
                    }
                    
                    return (account, "Account retrieved successfully.", true);
                }
            }
            catch (Exception ex)
            {
                return (null, $"Error retrieving account: {ex.Message}", false);
            }
        }
    }
}
