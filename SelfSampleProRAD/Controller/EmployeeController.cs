using Microsoft.VisualBasic.ApplicationServices;
using SelfSampleProRAD_DB.Model;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SelfSampleProRAD_DB.Controller
{
    class EmployeeController
    {
        private readonly AppDbContext _context;

        public EmployeeController(AppDbContext context)
        {
            _context = context;
        }

        public string AddEmployee(string fName, string lName, char gen, byte age, string pos, string cat)
        {
            using var transaction = _context.Database.BeginTransaction();
            try
            {
                var employee = new Employee
                {
                    FirstName = fName,
                    LastName = lName,
                    Gender = gen,
                    Age = age,
                    Position = pos,
                    Catagory = cat
                };

                _context.Employee.Add(employee);
                _context.SaveChanges(); // Saves and generates EmployeeId

                var userName = $"{lName}_{fName}@{employee.EmployeeId.ToString().Substring(0,3)}";
                var account = new Account
                {
                    UserName = userName,
                    Password = GenerateRandomPassword(),
                    Status = 'A'
                };

                _context.Account.Add(account);
                _context.SaveChanges(); // Saves and generates AccountId/UserId

                // Link Employee to Account
                employee.UserId = account.UserId;
                _context.SaveChanges();

                transaction.Commit();
                return "Successfully added an Employee and created an Account";
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                MessageBox.Show("Error: " + ex.Message);
                return "Something went wrong while adding the Employee and Account";
            }
        }

        //public void SelectEmployee(string usrName, string pwd)
        //{

        //}
        //public SqlDataReader ListAllEmployees()
        //{

        //}
        //public void calaculateTax()
        //{

        //}
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
