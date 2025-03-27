using SelfSampleProRAD_DB.DTOs;
using SelfSampleProRAD_DB_SQL.Models;
using SelfSampleProRAD_DB_SQL.DB;
using System.Data;
using System.Text;

namespace SelfSampleProRAD_DB.Controller
{
    class EmployeeController
    {
        
        public (string, bool) AddEmployee(string fName, string lName, char gen, byte age, string pos, string cat)
        {
            float salary;
            float tax;
            calaculateTax(pos, out salary, out tax);

            try
            {
                using (SqlConnection connection = new DBConnection().openConnection())
                {
                    // Check if employee already exists
                    string checkQuery = "SELECT COUNT(*) FROM Employee WHERE FirstName = @FirstName AND LastName = @LastName";
                    using (SqlCommand checkCommand = new SqlCommand(checkQuery, connection))
                    {
                        checkCommand.Parameters.AddWithValue("@FirstName", fName);
                        checkCommand.Parameters.AddWithValue("@LastName", lName);
                        int count = (int)checkCommand.ExecuteScalar();

                        if (count > 0)
                            return ($"Employee {fName} {lName} Already Exists", false);
                    }

                    // Create employee model
                    var employee = new Employee
                    {
                        EmployeeId = Guid.NewGuid(),
                        FirstName = fName,
                        LastName = lName,
                        Gender = gen,
                        Age = age,
                        Position = pos,
                        Salary = salary,
                        Tax = tax,
                        Category = cat
                    };

                    // Create account model
                    string userName = $"{lName}_{fName}@{employee.EmployeeId.ToString().Substring(0, 3)}";
                    string password = GenerateRandomPassword();
                    
                    var account = new Account
                    {
                        UserID = Guid.NewGuid(),
                        UserName = userName,
                        Password = password,
                        Status = 'A'
                    };

                    // Begin transaction
                    SqlTransaction transaction = connection.BeginTransaction();

                    try
                    {
                        // Insert employee
                        string employeeSql = @"INSERT INTO Employee (EmployeeId, FirstName, LastName, Gender, Age, Position, Salary, Tax, Category) 
                                             VALUES (@EmployeeId, @FirstName, @LastName, @Gender, @Age, @Position, @Salary, @Tax, @Category)";

                        using (SqlCommand employeeCommand = new SqlCommand(employeeSql, connection, transaction))
                        {
                            employeeCommand.Parameters.AddWithValue("@EmployeeId", employee.EmployeeId);
                            employeeCommand.Parameters.AddWithValue("@FirstName", employee.FirstName);
                            employeeCommand.Parameters.AddWithValue("@LastName", employee.LastName);
                            employeeCommand.Parameters.AddWithValue("@Gender", employee.Gender);
                            employeeCommand.Parameters.AddWithValue("@Age", employee.Age);
                            employeeCommand.Parameters.AddWithValue("@Position", employee.Position);
                            employeeCommand.Parameters.AddWithValue("@Salary", employee.Salary);
                            employeeCommand.Parameters.AddWithValue("@Tax", employee.Tax);
                            employeeCommand.Parameters.AddWithValue("@Category", employee.Category);
                            employeeCommand.ExecuteNonQuery();
                        }

                        // Insert account
                        string accountSql = @"INSERT INTO Account (UserId, UserName, Password, Status) 
                                            VALUES (@UserId, @UserName, @Password, @Status)";

                        using (SqlCommand accountCommand = new SqlCommand(accountSql, connection, transaction))
                        {
                            accountCommand.Parameters.AddWithValue("@UserId", account.UserID);
                            accountCommand.Parameters.AddWithValue("@UserName", account.UserName);
                            accountCommand.Parameters.AddWithValue("@Password", account.Password);
                            accountCommand.Parameters.AddWithValue("@Status", account.Status);
                            accountCommand.ExecuteNonQuery();
                        }

                        // Link employee to account
                        employee.UserId = account.UserID;
                        string updateSql = "UPDATE Employee SET UserId = @UserId WHERE EmployeeId = @EmployeeId";

                        using (SqlCommand updateCommand = new SqlCommand(updateSql, connection, transaction))
                        {
                            updateCommand.Parameters.AddWithValue("@UserId", employee.UserId);
                            updateCommand.Parameters.AddWithValue("@EmployeeId", employee.EmployeeId);
                            updateCommand.ExecuteNonQuery();
                        }

                        // Set up navigation properties
                        employee.Account = account;
                        account.Employee = employee;

                        transaction.Commit();
                        return ("Successfully added an Employee and created an Account", true);
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        return (ex.Message, false);
                    }
                }
            }
            catch (Exception ex)
            {
                return (ex.Message, false);
            }
        }

        public (string, bool) UpdateEmployee(EmployeeEditDTO employee)
        {
            bool isNameChanged = false;
            try
            {
                using (SqlConnection connection = new DBConnection().openConnection())
                {
                    // First check if employee exists and get current name
                    string checkQuery = "SELECT FirstName, LastName, UserId FROM Employee WHERE EmployeeId = @EmployeeId";
                    string currentFirstName = null;
                    string currentLastName = null;
                    Guid? userId = null;

                    using (SqlCommand checkCommand = new SqlCommand(checkQuery, connection))
                    {
                        checkCommand.Parameters.AddWithValue("@EmployeeId", employee.EmployeeId);

                        using (SqlDataReader reader = checkCommand.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                currentFirstName = reader["FirstName"].ToString();
                                currentLastName = reader["LastName"].ToString();
                                if (reader["UserId"] != DBNull.Value)
                                    userId = (Guid)reader["UserId"];
                            }
                            else
                            {
                                return ("Employee not found.", false);
                            }
                        }
                    }

                    // Check if name changed
                    if (currentFirstName != employee.FirstName || currentLastName != employee.LastName)
                        isNameChanged = true;

                    // Update employee
                    string updateSql = @"UPDATE Employee 
                                       SET FirstName = @FirstName, LastName = @LastName, 
                                           Age = @Age, Gender = @Gender 
                                       WHERE EmployeeId = @EmployeeId";

                    using (SqlCommand updateCommand = new SqlCommand(updateSql, connection))
                    {
                        updateCommand.Parameters.AddWithValue("@FirstName", employee.FirstName);
                        updateCommand.Parameters.AddWithValue("@LastName", employee.LastName);
                        updateCommand.Parameters.AddWithValue("@Age", employee.Age);
                        updateCommand.Parameters.AddWithValue("@Gender", employee.Gender);
                        updateCommand.Parameters.AddWithValue("@EmployeeId", employee.EmployeeId);
                        updateCommand.ExecuteNonQuery();
                    }

                    // Update username if name changed
                    if (isNameChanged && userId.HasValue)
                    {
                        string newUserName = $"{employee.LastName}_{employee.FirstName}@{employee.EmployeeId.ToString().Substring(0, 3)}";
                        string updateAccountSql = "UPDATE Account SET UserName = @UserName WHERE UserId = @UserId";

                        using (SqlCommand updateAccountCommand = new SqlCommand(updateAccountSql, connection))
                        {
                            updateAccountCommand.Parameters.AddWithValue("@UserName", newUserName);
                            updateAccountCommand.Parameters.AddWithValue("@UserId", userId.Value);
                            updateAccountCommand.ExecuteNonQuery();
                        }
                    }

                    return ("Employee Updated Successfully.", true);
                }
            }
            catch (Exception ex)
            {
                return ("Unable to Update Employee.\nError: " + ex.Message, false);
            }
        }

        public Employee? SelectEmployee(Guid employeeId)
        {
            try
            {
                using (SqlConnection connection = new DBConnection().openConnection())
                {
                    string query = @"SELECT e.EmployeeId, e.FirstName, e.LastName, e.Gender, e.Age, 
                                   e.Position, e.Salary, e.Tax, e.Category, e.UserId, 
                                   a.UserName, a.Password, a.Status 
                                   FROM Employee e 
                                   LEFT JOIN Account a ON e.UserId = a.UserId 
                                   WHERE e.EmployeeId = @EmployeeId";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@EmployeeId", employeeId);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                var employee = new Employee
                                {
                                    EmployeeId = (Guid)reader["EmployeeId"],
                                    FirstName = reader["FirstName"].ToString(),
                                    LastName = reader["LastName"].ToString(),
                                    Gender = Convert.ToChar(reader["Gender"]),
                                    Age = Convert.ToByte(reader["Age"]),
                                    Position = reader["Position"].ToString(),
                                    Salary = Convert.ToSingle(reader["Salary"]),
                                    Tax = Convert.ToSingle(reader["Tax"]),
                                    Category = reader["Category"].ToString()
                                };

                                if (reader["UserId"] != DBNull.Value)
                                {
                                    employee.UserId = (Guid)reader["UserId"];

                                    if (reader["UserName"] != DBNull.Value)
                                    {
                                        employee.Account = new Account
                                        {
                                            UserID = (Guid)reader["UserId"],
                                            UserName = reader["UserName"].ToString(),
                                            Password = reader["Password"].ToString(),
                                            Status = Convert.ToChar(reader["Status"])
                                        };
                                        
                                        // Set the bidirectional relationship
                                        employee.Account.Employee = employee;
                                    }
                                }

                                return employee;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions as needed
                MessageBox.Show($"Error in SelectEmployee: {ex.Message}","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

            return null;
        }

        public Employee? SelectEmployeeByUserId(Guid UserId)
        {
            try
            {
                using (SqlConnection connection = new DBConnection().openConnection())
                {
                    string query = @"SELECT e.EmployeeId, e.FirstName, e.LastName, e.Gender, e.Age, 
                                   e.Position, e.Salary, e.Tax, e.Category, 
                                   a.UserName, a.Status 
                                   FROM Employee e 
                                   LEFT JOIN Account a ON e.UserId = a.UserId 
                                   WHERE e.UserId = @UserId";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@UserId", UserId);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                var employee = new Employee
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
                                    UserId = UserId
                                };

                                if (reader["UserName"] != DBNull.Value)
                                {
                                    employee.Account = new Account
                                    {
                                        UserID = UserId,
                                        UserName = reader["UserName"].ToString(),
                                        Status = Convert.ToChar(reader["Status"])
                                    };
                                    
                                    // Set the bidirectional relationship
                                    employee.Account.Employee = employee;
                                }

                                return employee;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions as needed
                MessageBox.Show($"Error in SelectEmployeeByUserId: {ex.Message}","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

            return null;
        }

        public List<EmployeeResponseDTO> ListAllEmployees()
        {
            var employees = new List<EmployeeResponseDTO>();

            try
            {
                using (SqlConnection connection = new DBConnection().openConnection())
                {
                    string query = @"SELECT e.EmployeeId, e.FirstName, e.LastName, e.Gender, e.Age, 
                                   e.Position, e.Salary, e.Tax, e.Category, 
                                   a.UserId, a.UserName, a.Status 
                                   FROM Employee e 
                                   LEFT JOIN Account a ON e.UserId = a.UserId";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var employee = new EmployeeResponseDTO
                            {
                                EmployeeId = (Guid)reader["EmployeeId"],
                                FirstName = reader["FirstName"].ToString(),
                                LastName = reader["LastName"].ToString(),
                                Gender = Convert.ToChar(reader["Gender"]),
                                Age = Convert.ToByte(reader["Age"]),
                                Position = reader["Position"].ToString(),
                                Salary = Convert.ToSingle(reader["Salary"]),
                                Tax = Convert.ToSingle(reader["Tax"]),
                                Catagory = reader["Category"].ToString()
                            };

                            if (reader["UserId"] != DBNull.Value)
                            {
                                employee.accountdto = new AccountResponseDTO
                                {
                                    UserId = (Guid)reader["UserId"],
                                    UserName = reader["UserName"].ToString(),
                                    Status = Convert.ToChar(reader["Status"])
                                };
                            }

                            employees.Add(employee);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions as needed
                MessageBox.Show($"Error in ListAllEmployees: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return employees;
        }

        private void calaculateTax(string position, out float Salary, out float Tax)
        {
            if (position == "Developer" || position == "Manager")
            {
                Salary = 30000f;
                Tax = Salary * (35f / 100);
            }
            else
            {
                Salary = 10000f;
                Tax = Salary * (15f / 100);
            }
        }

        private string GenerateRandomPassword(int length = 12)
        {
            const string upperCase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            const string lowerCase = "abcdefghijklmnopqrstuvwxyz";
            const string digits = "0123456789";
            const string special = "!@#$%^&*()_-+=[{]};:<>|./?";

            var random = new Random();
            var password = new StringBuilder();

            // Ensure at least one character from each category
            password.Append(upperCase[random.Next(upperCase.Length)]);
            password.Append(lowerCase[random.Next(lowerCase.Length)]);
            password.Append(digits[random.Next(digits.Length)]);
            password.Append(special[random.Next(special.Length)]);

            // Fill the rest of the password
            var allChars = upperCase + lowerCase + digits + special;
            for (int i = 4; i < length; i++)
            {
                password.Append(allChars[random.Next(allChars.Length)]);
            }

            // Shuffle the password
            return new string(password.ToString().OrderBy(c => random.Next()).ToArray());
        }
    }
}
