using SelfSampleProRAD_DB.Model;
namespace SelfSampleProRAD_DB.Data
{
    public class SuperAdminSeeder
    {
        private readonly AppDbContext _context;

        public SuperAdminSeeder(AppDbContext context)
        {
            _context = context;
        }

        public void SeedSuperAdmin()
        {
            var superAdminUserName = "SuperAdmin@001";

            if (_context.Account.Any(a => a.UserName == superAdminUserName))
                return;

            try
            {
                var employee = new Employee
                {
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
