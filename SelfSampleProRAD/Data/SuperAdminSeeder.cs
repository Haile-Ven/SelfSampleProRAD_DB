using SelfSampleProRAD_DB.Model;
namespace SelfSampleProRAD_DB.Data
{
    public class SuperAdminSeeder
    {
        private readonly AppDbContext _context;
        // Define static GUIDs for the super admin
        private static readonly Guid SuperAdminEmployeeId = new Guid("11111111-1111-1111-1111-111111111111");
        private static readonly Guid SuperAdminUserId = new Guid("22222222-2222-2222-2222-222222222222");

        public SuperAdminSeeder(AppDbContext context)
        {
            _context = context;
        }

        public void SeedSuperAdmin()
        {
            var superAdminUserName = "SuperAdmin@001";

            // Check if super admin exists by the static EmployeeId
            if (_context.Employee.Any(e => e.EmployeeId == SuperAdminEmployeeId))
                return;

            try
            {
                var employee = new Employee
                {
                    EmployeeId = SuperAdminEmployeeId,  // Use the static EmployeeId
                    FirstName = "John",
                    LastName = "Doe",
                    Gender = 'M',
                    Age = 35,
                    Position = "Admin",
                    Catagory = "Permanent",
                    Salary = 50000,
                    Tax = 5000
                };

                _context.Employee.Add(employee);
                _context.SaveChanges();

                var account = new Account
                {
                    UserId = SuperAdminUserId,  // Use the static UserId
                    UserName = superAdminUserName,
                    Password = "P@55w0rd123456",
                    Status = 'A'
                };

                _context.Account.Add(account);
                _context.SaveChanges();

                // Now link the employee to the account
                employee.UserId = account.UserId;
                _context.Employee.Update(employee);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
