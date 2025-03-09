using SelfSampleProRAD_DB.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                    FirstName = "Jhon",
                    LastName = "Doe",
                    Gender = 'M',
                    Age = 35,
                    Position = "Super Admin",
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
                MessageBox.Show(ex.InnerException.Message);
            }
        }
    }
}
