using SelfSampleProRAD_DB_SQL.DB;
using SelfSampleProRAD_DB_SQL.Models;

namespace SelfSampleProRAD_DB_SQL.Data
{
    public class SuperAdminSeeder
    {
        // Define static GUIDs for the super admin
        private static readonly Guid SuperAdminEmployeeId = new Guid("11111111-1111-1111-1111-111111111111");
        private static readonly Guid SuperAdminUserId = new Guid("22222222-2222-2222-2222-222222222222");

        public void SeedSuperAdmin()
        {
            try
            {
                using (SqlConnection con = new DBConnection().openConnection())
                {
                    // Check if super admin exists by the static EmployeeId
                    string checkSql = "SELECT COUNT(*) FROM Employee WHERE EmployeeId = @EmployeeId";
                    using (SqlCommand checkCmd = new SqlCommand(checkSql, con))
                    {
                        checkCmd.Parameters.AddWithValue("@EmployeeId", SuperAdminEmployeeId);
                        int count = (int)checkCmd.ExecuteScalar();
                        
                        // If super admin already exists, return
                        if (count > 0)
                            return;
                    }

                    // Create employee model
                    var employee = new Employee
                    {
                        EmployeeId = SuperAdminEmployeeId,
                        FirstName = "Doe",
                        LastName = "John",
                        Gender = 'M',
                        Age = 35,
                        Position = "Admin",
                        Category = "Permanent",
                        Salary = 50000f,
                        Tax = 5000f
                    };

                    // Create account model
                    var account = new Account
                    {
                        UserID = SuperAdminUserId,
                        UserName = "SuperAdmin@001",
                        Password = "Admin@123",
                        Status = 'A'
                    };

                    // Create Employee record
                    string employeeSql = @"INSERT INTO Employee (EmployeeId, FirstName, LastName, Gender, Age, Position, Category, Salary, Tax, UserId) 
                                           VALUES (@EmployeeId, @FirstName, @LastName, @Gender, @Age, @Position, @Category, @Salary, @Tax, @UserId)";
                    
                    using (SqlCommand employeeCmd = new SqlCommand(employeeSql, con))
                    {
                        employeeCmd.Parameters.AddWithValue("@EmployeeId", employee.EmployeeId);
                        employeeCmd.Parameters.AddWithValue("@FirstName", employee.FirstName);
                        employeeCmd.Parameters.AddWithValue("@LastName", employee.LastName);
                        employeeCmd.Parameters.AddWithValue("@Gender", employee.Gender);
                        employeeCmd.Parameters.AddWithValue("@Age", employee.Age);
                        employeeCmd.Parameters.AddWithValue("@Position", employee.Position);
                        employeeCmd.Parameters.AddWithValue("@Category", employee.Category);
                        employeeCmd.Parameters.AddWithValue("@Salary", employee.Salary);
                        employeeCmd.Parameters.AddWithValue("@Tax", employee.Tax);
                        employeeCmd.Parameters.AddWithValue("@UserId", DBNull.Value); // Will be updated after account creation
                        
                        employeeCmd.ExecuteNonQuery();
                    }

                    // Create Account record
                    string accountSql = @"INSERT INTO Account (UserId, UserName, Password, Status) 
                                          VALUES (@UserId, @UserName, @Password, @Status)";
                    
                    using (SqlCommand accountCmd = new SqlCommand(accountSql, con))
                    {
                        accountCmd.Parameters.AddWithValue("@UserId", account.UserID);
                        accountCmd.Parameters.AddWithValue("@UserName", account.UserName);
                        accountCmd.Parameters.AddWithValue("@Password", account.Password);
                        accountCmd.Parameters.AddWithValue("@Status", account.Status);
                        
                        accountCmd.ExecuteNonQuery();
                    }

                    // Link Employee to Account
                    string updateSql = "UPDATE Employee SET UserId = @UserId WHERE EmployeeId = @EmployeeId";
                    
                    using (SqlCommand updateCmd = new SqlCommand(updateSql, con))
                    {
                        updateCmd.Parameters.AddWithValue("@UserId", account.UserID);
                        updateCmd.Parameters.AddWithValue("@EmployeeId", employee.EmployeeId);
                        
                        updateCmd.ExecuteNonQuery();
                    }

                    // Set up navigation properties
                    employee.UserId = account.UserID;
                    employee.Account = account;
                    account.Employee = employee;
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions
                System.Windows.Forms.MessageBox.Show($"Error seeding super admin: {ex.Message}", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }
    }
}
