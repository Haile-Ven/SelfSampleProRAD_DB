using SelfSampleProRAD_DB.DTOs;
using SelfSampleProRAD_DB_SQL.Models;
using SelfSampleProRAD_DB_SQL.DB;
namespace SelfSampleProRAD_DB.Controller
{
    class AccountController
    {
        public AccountController()
        {
        }

        //Login
        public (EmployeeResponseDTO, string) Login(string userNm, string pass)
        {
            try
            {
                using (SqlConnection connection = new DBConnection().openConnection())
                {
                    // First find the account by username only
                    string query = @"SELECT a.UserId, a.UserName, a.Status, a.Password, 
                                    e.EmployeeId, e.FirstName, e.LastName, e.Gender, e.Age, 
                                    e.Position, e.Salary, e.Tax, e.Category 
                                    FROM Account a 
                                    INNER JOIN Employee e ON a.UserId = e.UserId 
                                    WHERE a.UserName = @UserName";
                    
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@UserName", userNm);
                        
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Check password match
                                string storedPassword = reader["Password"].ToString();
                                char status = Convert.ToChar(reader["Status"]);
                                
                                if (storedPassword != pass)
                                    return (null, "Invalid Username or Password.");
                                    
                                // Check if account is deactivated
                                if (status == 'D')
                                    return (null, "Account is deactivated.");
                                    
                                // Map to DTO
                                var account = new EmployeeResponseDTO()
                                {
                                    EmployeeId = (Guid)reader["EmployeeId"],
                                    FirstName = reader["FirstName"].ToString(),
                                    LastName = reader["LastName"].ToString(),
                                    Gender = Convert.ToChar(reader["Gender"]),
                                    Age = Convert.ToByte(reader["Age"]),
                                    Position = reader["Position"].ToString(),
                                    Salary = Convert.ToSingle(reader["Salary"]),
                                    Tax = Convert.ToSingle(reader["Tax"]),
                                    Catagory = reader["Category"].ToString(),
                                    accountdto = new AccountResponseDTO()
                                    {
                                        UserId = (Guid)reader["UserId"],
                                        UserName = reader["UserName"].ToString(),
                                        Status = status
                                    }
                                };
                                
                                return (account, "Login Successful.");
                            }
                            else
                            {
                                return (null, "Invalid Username or Password.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                return (null, "Error: " + ex.Message);
            }
        }

        //Change password
        public (string,bool) ChangePassword(Guid employeeId, string oldPass, string newPass)
        {
            try
            {
                using (SqlConnection connection = new DBConnection().openConnection())
                {
                    // First, find the employee by employeeId
                    string employeeQuery = "SELECT UserId FROM Employee WHERE EmployeeId = @EmployeeId";
                    Guid userId;
                    
                    using (SqlCommand employeeCommand = new SqlCommand(employeeQuery, connection))
                    {
                        employeeCommand.Parameters.AddWithValue("@EmployeeId", employeeId);
                        var result = employeeCommand.ExecuteScalar();
                        
                        if (result == null || result == DBNull.Value)
                            return ("Employee not found.", false);
                            
                        userId = (Guid)result;
                    }
                    
                    // Now find the account using the userId
                    string accountQuery = "SELECT Password FROM Account WHERE UserId = @UserId";
                    string currentPassword;
                    
                    using (SqlCommand accountCommand = new SqlCommand(accountQuery, connection))
                    {
                        accountCommand.Parameters.AddWithValue("@UserId", userId);
                        var result = accountCommand.ExecuteScalar();
                        
                        if (result == null || result == DBNull.Value)
                            return ("Account not found.", false);
                            
                        currentPassword = result.ToString();
                    }
                    
                    // Verify old password
                    if (currentPassword != oldPass)
                        return ("Old Password is incorrect.", false);
                        
                    // Update the password
                    string updateQuery = "UPDATE Account SET Password = @NewPassword WHERE UserId = @UserId";
                    
                    using (SqlCommand updateCommand = new SqlCommand(updateQuery, connection))
                    {
                        updateCommand.Parameters.AddWithValue("@NewPassword", newPass);
                        updateCommand.Parameters.AddWithValue("@UserId", userId);
                        updateCommand.ExecuteNonQuery();
                    }
                    
                    return ("Password Changed Successfully.", true);
                }
            }
            catch (Exception ex)
            {
                return ("Unable to Change Password.\nError: " + ex.Message, false);
            }
        }

        //List all accounts
        public List<AccountResponseDTO> ListAllAccounts()
        {
            var accounts = new List<AccountResponseDTO>();
            
            try
            {
                using (SqlConnection connection = new DBConnection().openConnection())
                {
                    string query = "SELECT UserId, UserName, Status FROM Account";
                    
                    using (SqlCommand command = new SqlCommand(query, connection))
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            accounts.Add(new AccountResponseDTO()
                            {
                                UserId = (Guid)reader["UserId"],
                                UserName = reader["UserName"].ToString(),
                                Status = Convert.ToChar(reader["Status"])
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in ListAllAccounts: {ex.Message}");
            }
            
            return accounts;
        }

        public List<AccountResponseDTO> ListAllDevs()
        {
            var devs = new List<AccountResponseDTO>();
            
            try
            {
                using (SqlConnection connection = new DBConnection().openConnection())
                {
                    string query = @"SELECT a.UserId, a.UserName, a.Status 
                                   FROM Account a 
                                   INNER JOIN Employee e ON a.UserId = e.UserId 
                                   WHERE e.Position = 'Developer'";
                    
                    using (SqlCommand command = new SqlCommand(query, connection))
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            devs.Add(new AccountResponseDTO()
                            {
                                UserId = (Guid)reader["UserId"],
                                UserName = reader["UserName"].ToString(),
                                Status = Convert.ToChar(reader["Status"])
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in ListAllDevs: {ex.Message}");
            }
            
            return devs;
        }

        public Account FindAccountByID(Guid? id)
        {
            if (id == null)
                return null;
                
            try
            {
                using (SqlConnection connection = new DBConnection().openConnection())
                {
                    // First get the account information
                    string accountQuery = "SELECT UserId, UserName, Password, Status FROM Account WHERE UserId = @UserId";
                    Account account = null;
                    
                    using (SqlCommand accountCommand = new SqlCommand(accountQuery, connection))
                    {
                        accountCommand.Parameters.AddWithValue("@UserId", id);
                        
                        using (SqlDataReader reader = accountCommand.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                account = new Account()
                                {
                                    UserID = (Guid)reader["UserId"],
                                    UserName = reader["UserName"].ToString(),
                                    Password = reader["Password"].ToString(),
                                    Status = Convert.ToChar(reader["Status"])
                                };
                            }
                            else
                            {
                                return null; // Account not found
                            }
                        }
                    }
                    
                    // Now get the associated employee information
                    string employeeQuery = "SELECT EmployeeId, FirstName, LastName, Gender, Age, Position, Salary, Tax, Category FROM Employee WHERE UserId = @UserId";
                    
                    using (SqlCommand employeeCommand = new SqlCommand(employeeQuery, connection))
                    {
                        employeeCommand.Parameters.AddWithValue("@UserId", id);
                        
                        using (SqlDataReader reader = employeeCommand.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                account.Employee = new Employee()
                                {
                                    EmployeeId = (Guid)reader["EmployeeId"],
                                    FirstName = reader["FirstName"].ToString(),
                                    LastName = reader["LastName"].ToString(),
                                    Gender = Convert.ToChar(reader["Gender"]),
                                    Age = Convert.ToByte(reader["Age"]),
                                    Position = reader["Position"].ToString(),
                                    Salary = Convert.ToSingle(reader["Salary"]),
                                    Tax = Convert.ToSingle(reader["Tax"]),
                                    Category = reader["Category"].ToString(),
                                    UserId = id
                                };
                                
                                // Set the bidirectional relationship
                                account.Employee.Account = account;
                            }
                        }
                    }
                    
                    return account;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in FindAccountByID: {ex.Message}");
            }
            
            return null;
        }

        //Change account status (Activate/Deactivate)
        public (string, bool) ChangeAccountStatus(Guid accId)
        {
            try
            {
                using (SqlConnection connection = new DBConnection().openConnection())
                {
                    // First, get the current status
                    string statusQuery = "SELECT Status FROM Account WHERE UserId = @UserId";
                    char currentStatus;
                    
                    using (SqlCommand statusCommand = new SqlCommand(statusQuery, connection))
                    {
                        statusCommand.Parameters.AddWithValue("@UserId", accId);
                        var result = statusCommand.ExecuteScalar();
                        
                        if (result == null || result == DBNull.Value)
                            return ("Account not found.", false);
                            
                        currentStatus = Convert.ToChar(result);
                    }
                    
                    // Toggle the status
                    char newStatus = currentStatus == 'A' ? 'D' : 'A';
                    
                    // Update the status
                    string updateQuery = "UPDATE Account SET Status = @NewStatus WHERE UserId = @UserId";
                    
                    using (SqlCommand updateCommand = new SqlCommand(updateQuery, connection))
                    {
                        updateCommand.Parameters.AddWithValue("@NewStatus", newStatus);
                        updateCommand.Parameters.AddWithValue("@UserId", accId);
                        updateCommand.ExecuteNonQuery();
                    }
                    
                    var msg = newStatus == 'A' ? "Account Activated Successfully." : "Account Deactivated Successfully.";
                    return (msg, true);
                }
            }
            catch (Exception ex)
            {
                return ("Unable to Change Account Status.\nError: " + ex.Message, false);
            }
        }
    }
}