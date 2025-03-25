using SelfSampleProRAD_DB_SQL.DB;
using SelfSampleProRAD_DB_SQL.DTOs;
using SelfSampleProRAD_DB_SQL.Models;
using System.Collections.Generic;
namespace SelfSampleProRAD_DB_SQL.Controllers
{
    internal class EmployeeController
    {
        //Methods
        public (Employee, string, bool) AddEmployee(EmployeeCreateDTO employeeDTO)
        {
            var salTax = CalaculateSalaryTax(employeeDTO.Position);
            Employee employee = new Employee
            {
                FirstName = employeeDTO.FirstName,
                LastName = employeeDTO.LastName,
                Gender = employeeDTO.Gender,
                Age = employeeDTO.Age,
                Position = employeeDTO.Position,
                Category = employeeDTO.Category,
                Salary = salTax.Item1,
                Tax = salTax.Item2
            };

            try
            {
                using (SqlConnection con = new DBConnection().openConnection())
                {
                   using (SqlTransaction transaction = con.BeginTransaction())
                    {
                        try
                        {
                            // Step 1: Insert Employee
                            string sql = "INSERT INTO Employee (EmployeeId, FirstName, LastName, Age, Gender, Position, Category, Salary, Tax) " +
                                         "VALUES (@EmployeeID, @FirstName, @LastName, @Age, @Gender, @Position, @Category, @Salary, @Tax);";

                            using (SqlCommand cmd = new SqlCommand(sql, con, transaction))
                            {
                                cmd.Parameters.AddWithValue("@EmployeeId", employee.EmployeeId);
                                cmd.Parameters.AddWithValue("@FirstName", employee.FirstName);
                                cmd.Parameters.AddWithValue("@LastName", employee.LastName);
                                cmd.Parameters.AddWithValue("@Age", employee.Age);
                                cmd.Parameters.AddWithValue("@Gender", employee.Gender);
                                cmd.Parameters.AddWithValue("@Position", employee.Position);
                                cmd.Parameters.AddWithValue("@Category", employee.Category);
                                cmd.Parameters.AddWithValue("@Salary", employee.Salary);
                                cmd.Parameters.AddWithValue("@Tax", employee.Tax);

                                if (cmd.ExecuteNonQuery() <= 0)
                                {
                                    transaction.Rollback();
                                    return (null, "Failed to insert employee.", false);
                                }
                            }

                            // Step 2: Create Account and Get UserID
                            Account account = new Account
                            {
                                UserName = $"{employee.FirstName}_{employee.LastName}@{employee.EmployeeId.ToString().Substring(0, 3)}".ToLower(),
                                Password = GenerateRandomPassword(),
                                Status = 'A'
                            };

                            string accountSql = "INSERT INTO Account (UserId, UserName, Password, Status) " +
                                                "VALUES (@UserId,@UserName, @Password, @Status); ";

                            using (SqlCommand accCmd = new SqlCommand(accountSql, con, transaction))
                            {
                                accCmd.Parameters.AddWithValue("@UserId", account.UserID);
                                accCmd.Parameters.AddWithValue("@UserName", account.UserName);
                                accCmd.Parameters.AddWithValue("@Password", account.Password);
                                accCmd.Parameters.AddWithValue("@Status", account.Status);

                                object result = accCmd.ExecuteScalar();
                                if (result == null || result == DBNull.Value)
                                {
                                    transaction.Rollback();
                                    return (null, "Failed to create account.", false);
                                }
                                employee.UserId = account.UserID; // Assign UserID to Employee
                            }

                            // Step 3: Update Employee with UserID from Account
                            string updateSql = "UPDATE Employee SET UserId = @UserId WHERE EmployeeId = @EmployeeId";

                            using (SqlCommand updateCmd = new SqlCommand(updateSql, con, transaction))
                            {
                                updateCmd.Parameters.AddWithValue("@UserId", employee.UserId);
                                updateCmd.Parameters.AddWithValue("@EmployeeId", employee.EmployeeId);

                                if (updateCmd.ExecuteNonQuery() <= 0)
                                {
                                    transaction.Rollback();
                                    return (null, "Failed to associate Account with Employee.", false);
                                }
                            }

                            // Step 4: Commit Transaction (only if everything succeeds)
                            transaction.Commit();
                            return (employee, "Employee registered and account created successfully.", true);
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback(); // Ensure rollback on failure
                            return (null, ex.Message, false);
                        }
                    }
                }
            }
            catch (Exception dbEx)
            {
                return (null, dbEx.Message, false);
            }
        }

        public (Employee, string, bool) EditEmployee(Guid employeeId, Employee updatedEmployee)
        {
            try
            {
                // First, get the current employee to check if name has changed
                var (currentEmployee, message, success) = GetEmployeeWithAccount(employeeId);
                
                if (!success)
                {
                    return (null, message, false);
                }
                
                bool nameChanged = currentEmployee.FirstName != updatedEmployee.FirstName || 
                                  currentEmployee.LastName != updatedEmployee.LastName;
                
                using (SqlConnection con = new DBConnection().openConnection())
                {
                    using (SqlTransaction transaction = con.BeginTransaction())
                    {
                        try
                        {
                            // Update Employee information
                            string sql = @"UPDATE Employee 
                                          SET FirstName = @FirstName, 
                                              LastName = @LastName, 
                                              Age = @Age, 
                                              Gender = @Gender, 
                                              Position = @Position, 
                                              Category = @Category, 
                                              Salary = @Salary, 
                                              Tax = @Tax 
                                          WHERE EmployeeId = @EmployeeId";
                            
                            using (SqlCommand cmd = new SqlCommand(sql, con, transaction))
                            {
                                cmd.Parameters.AddWithValue("@EmployeeId", employeeId);
                                cmd.Parameters.AddWithValue("@FirstName", updatedEmployee.FirstName);
                                cmd.Parameters.AddWithValue("@LastName", updatedEmployee.LastName);
                                cmd.Parameters.AddWithValue("@Age", updatedEmployee.Age);
                                cmd.Parameters.AddWithValue("@Gender", updatedEmployee.Gender);
                                cmd.Parameters.AddWithValue("@Position", updatedEmployee.Position);
                                cmd.Parameters.AddWithValue("@Category", updatedEmployee.Category);
                                cmd.Parameters.AddWithValue("@Salary", updatedEmployee.Salary);
                                cmd.Parameters.AddWithValue("@Tax", updatedEmployee.Tax);
                                
                                int rowsAffected = cmd.ExecuteNonQuery();
                                if (rowsAffected <= 0)
                                {
                                    transaction.Rollback();
                                    return (null, "Failed to update employee information.", false);
                                }
                            }
                            
                            // If name changed and employee has an account, update the username
                            if (nameChanged && currentEmployee.UserId.HasValue)
                            {
                                // Generate new username based on updated name
                                string newUsername = $"{updatedEmployee.FirstName}_{updatedEmployee.LastName}@{employeeId.ToString().Substring(0, 3)}".ToLower();
                                
                                string updateAccountSql = "UPDATE Account SET UserName = @UserName WHERE UserId = @UserId";
                                using (SqlCommand accountCmd = new SqlCommand(updateAccountSql, con, transaction))
                                {
                                    accountCmd.Parameters.AddWithValue("@UserId", currentEmployee.UserId.Value);
                                    accountCmd.Parameters.AddWithValue("@UserName", newUsername);
                                    
                                    int accountRowsAffected = accountCmd.ExecuteNonQuery();
                                    if (accountRowsAffected <= 0)
                                    {
                                        transaction.Rollback();
                                        return (null, "Failed to update account username.", false);
                                    }
                                }
                                
                                // Update the username in our object
                                if (updatedEmployee.Account != null)
                                {
                                    updatedEmployee.Account.UserName = newUsername;
                                }
                            }
                            
                            // Commit transaction if everything succeeded
                            transaction.Commit();
                            
                            // Get the updated employee with account
                            var (updatedEmployeeWithAccount, message2, success2) = GetEmployeeWithAccount(employeeId);
                            return (updatedEmployeeWithAccount, "Employee information updated successfully." + (nameChanged ? " Username has been updated." : ""), success2);
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            return (null, $"Error updating employee: {ex.Message}", false);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                return (null, $"Error: {ex.Message}", false);
            }
        }
        
       
        public (List<Employee>, string, bool) ListAllEmployees()
        {
            List<Employee> employees = new List<Employee>();
            
            try
            {
                using (SqlConnection con = new DBConnection().openConnection())
                {
                    string sql = "SELECT * FROM Employee";
                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Employee employee = new Employee
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
                                    UserId = reader.IsDBNull(reader.GetOrdinal("UserId")) ? 
                                             (Guid?)null : reader.GetGuid(reader.GetOrdinal("UserId"))
                                };
                                
                                employees.Add(employee);
                            }
                        }
                    }
                }
                
                return (employees, $"{employees.Count} employees retrieved successfully.", true);
            }
            catch (Exception ex)
            {
                return (null, $"Error retrieving employees: {ex.Message}", false);
            }
        }

        // Navigation methods to handle relationships without Entity Framework
        
        /// <summary>
        /// Gets an Employee with their associated Account loaded
        /// </summary>
        public (Employee, string, bool) GetEmployeeWithAccount(Guid employeeId)
        {
            Employee employee = null;
            
            try
            {
                using (SqlConnection con = new DBConnection().openConnection())
                {
                    // First, get the employee
                    string employeeSql = "SELECT * FROM Employee WHERE EmployeeId = @EmployeeId";
                    using (SqlCommand cmd = new SqlCommand(employeeSql, con))
                    {
                        cmd.Parameters.AddWithValue("@EmployeeId", employeeId);
                        
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                employee = new Employee
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
                                    UserId = reader.IsDBNull(reader.GetOrdinal("UserId")) ? 
                                             (Guid?)null : reader.GetGuid(reader.GetOrdinal("UserId"))
                                };
                            }
                            else
                            {
                                return (null, "Employee not found.", false);
                            }
                        }
                    }
                    
                    // If employee exists and has a UserId, get the associated account
                    if (employee != null && employee.UserId.HasValue)
                    {
                        string accountSql = "SELECT * FROM Account WHERE UserId = @UserId";
                        using (SqlCommand cmd = new SqlCommand(accountSql, con))
                        {
                            cmd.Parameters.AddWithValue("@UserId", employee.UserId.Value);
                            
                            using (SqlDataReader reader = cmd.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    employee.Account = new Account
                                    {
                                        UserID = reader.GetGuid(reader.GetOrdinal("UserId")),
                                        UserName = reader.GetString(reader.GetOrdinal("UserName")),
                                        Password = reader.GetString(reader.GetOrdinal("Password")),
                                        Status = reader.GetString(reader.GetOrdinal("Status"))[0]
                                    };
                                    
                                    // Set the back-reference to complete the navigation
                                    employee.Account.Employee = employee;
                                    return (employee, "Employee and account retrieved successfully.", true);
                                }
                                else
                                {
                                    return (employee, "Employee found but no associated account exists.", true);
                                }
                            }
                        }
                    }
                    
                    return (employee, "Employee retrieved successfully.", true);
                }
            }
            catch (Exception ex)
            {
                return (null, $"Error retrieving employee: {ex.Message}", false);
            }
        }

        //Helper Methods

        public (float, float) CalaculateSalaryTax(string Position)
        {
            float Salary = 0, Tax = 0;
            if (Position == "Developer")
            {
                Salary = 20000;
                Tax = Salary * (25F / 100);
                return (Salary, Tax);
            }
            if (Position == "Manager")
            {
                Salary = 30000;
                Tax = Salary * (35f / 100);
                return (Salary, Tax);
            }
            return (0, 0);
        }

        private string GenerateRandomPassword(int length = 12)
        {
            const string upperCase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            const string lowerCase = "abcdefghijklmnopqrstuvwxyz";
            const string numbers = "0123456789";
            const string specials = "!@#$%^&*";

            var random = new Random();
            var password = new List<char>
            {
                // Ensure at least one of each required character type
                upperCase[random.Next(upperCase.Length)],
                lowerCase[random.Next(lowerCase.Length)],
                numbers[random.Next(numbers.Length)],
                specials[random.Next(specials.Length)]
            };

            // Fill the rest with random characters from all types
            var allChars = upperCase + lowerCase + numbers + specials;
            var remainingLength = length - password.Count;

            password.AddRange(Enumerable.Range(0, remainingLength)
                .Select(_ => allChars[random.Next(allChars.Length)]));

            // Shuffle the password characters
            var shuffledPassword = password.OrderBy(_ => random.Next()).ToArray();
            return new string(shuffledPassword);
        }
    }
}
