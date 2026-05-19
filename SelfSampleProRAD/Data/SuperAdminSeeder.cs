using SelfSampleProRAD_DB_SQL.DB;
using SelfSampleProRAD_DB_SQL.Models;

namespace SelfSampleProRAD_DB_SQL.Data
{
    public class SuperAdminSeeder
    {
        private static readonly Guid SuperAdminEmployeeId = new Guid("11111111-1111-1111-1111-111111111111");
        private static readonly Guid SuperAdminUserId = new Guid("22222222-2222-2222-2222-222222222222");

        public void SeedSuperAdmin()
        {
            try
            {
                using (SqlConnection con = new DBConnection(null)._connection)
                {
                    string checkSql = "SELECT COUNT(*) FROM Employee WHERE EmployeeId = @EmployeeId";
                    using (SqlCommand checkCmd = new SqlCommand(checkSql, con))
                    {
                        checkCmd.Parameters.AddWithValue("@EmployeeId", SuperAdminEmployeeId);
                        int count = (int)checkCmd.ExecuteScalar();

                        if (count > 0)
                            return;
                    }

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

                    var account = new Account
                    {
                        UserID = SuperAdminUserId,
                        UserName = "SuperAdmin@001",
                        Password = "Admin@123",
                        Status = 'A'
                    };

                    string employeeSql = @"INSERT INTO Employee (EmployeeId, FirstName, LastName, Gender, Age, Position, Category, Salary, Tax, UserId) 
                                           VALUES (@EmployeeId, @FirstName, @LastName, @Gender, @Age, @Position, @Category, @Salary, @Tax, @UserId)";

                    SqlTransaction AdminSeederTransact = con.BeginTransaction();
                    try
                    {

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
                            employeeCmd.Parameters.AddWithValue("@UserId", DBNull.Value);       

                            employeeCmd.ExecuteNonQuery();
                        }

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

                        string updateSql = "UPDATE Employee SET UserId = @UserId WHERE EmployeeId = @EmployeeId";

                        using (SqlCommand updateCmd = new SqlCommand(updateSql, con))
                        {
                            updateCmd.Parameters.AddWithValue("@UserId", account.UserID);
                            updateCmd.Parameters.AddWithValue("@EmployeeId", employee.EmployeeId);

                            updateCmd.ExecuteNonQuery();
                        }

                        employee.UserId = account.UserID;
                        employee.Account = account;
                        account.Employee = employee;

                        AdminSeederTransact.Commit();
                    }
                    catch (Exception ex)
                    {
                        System.Windows.Forms.MessageBox.Show($"Error seeding super admin: {ex.Message}", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                        AdminSeederTransact.Rollback();
                    }
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show($"Error seeding super admin: {ex.Message}", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }
    }
}
