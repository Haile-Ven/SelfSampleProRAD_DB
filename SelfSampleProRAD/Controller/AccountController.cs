using SelfSampleProRAD_DB.DTOs;
using SelfSampleProRAD_DB.Model;
namespace SelfSampleProRAD_DB.Controller
{
    class AccountController
    {
        private readonly AppDbContext _context;

        public AccountController() : this(new AppDbContext()) { }

        public AccountController(AppDbContext context)
        {
            _context = context;
        }

        //Login
        public (EmployeeResponseDTO, string) Login(string userNm, string pass)
        {
            // First find the account by username only
            var accountEntity = _context.Account
                .Include(a => a.Employee)
                .Where(a => a.UserName == userNm)
                .FirstOrDefault();

            // If no account found or password doesn't match (case-sensitive)
            if (accountEntity == null || accountEntity.Password != pass)
                return (null, "Invalid Username or Password.");

            // Check if account is deactivated
            if (accountEntity.Status == 'D') 
                return (null, "Account is deactivated.");

            // Map to DTO
            var account = new EmployeeResponseDTO()
            {
                EmployeeId = accountEntity.Employee.EmployeeId,
                FirstName = accountEntity.Employee.FirstName,
                LastName = accountEntity.Employee.LastName,
                Gender = accountEntity.Employee.Gender,
                Age = accountEntity.Employee.Age,
                Position = accountEntity.Employee.Position,
                Salary = accountEntity.Employee.Salary,
                Tax = accountEntity.Employee.Tax,
                Catagory = accountEntity.Employee.Catagory,
                accountdto = new AccountResponseDTO()
                {
                    UserId = accountEntity.UserId,
                    UserName = accountEntity.UserName,
                    Status = accountEntity.Status
                }
            };

            return (account, "Login Successful.");
        }

        //Change password
        public (string,bool) ChangePassword(Guid employeeId, string oldPass, string newPass)
        {
            try
            {
                var employee = _context.Employee.Where(e => e.EmployeeId == employeeId).FirstOrDefault();
                var account = _context.Account.Where(a => a.UserId == employee.UserId).FirstOrDefault();
                if (account == null) return ("Account not found.",false);
                if (account.Password != oldPass) return ("Old Password is incorrect.", false);
                account.Password = newPass;
                _context.Update(account);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                return ("Unable to Change Password.\nError: " + ex.Message,false);
            }
            return ("Password Changed Successfully.", true);
        }

        //List all accounts
        public List<AccountResponseDTO> ListAllAccounts()
        {
            var accounts = _context.Account
                .Select(a => new AccountResponseDTO()
                {
                    UserId = a.UserId,
                    UserName = a.UserName,
                    Status = a.Status,
                })
                .ToList();
            return accounts;
        }

        public List<AccountResponseDTO> ListAllDevs()
        {
            var devs = _context.Account
                .Where(a => a.Employee.Position == "Developer")
                .Select(a => new AccountResponseDTO()
                {
                    UserId = a.UserId,
                    UserName = a.UserName,
                    Status = a.Status,
                })
                .ToList();
            return devs;
        }

        public Account FindAccountByID(Guid? id)
        {
            var account = _context.Account
                .Where(a => a.UserId == id)
                .Select(a => new Account()
                {
                    UserId = a.UserId,
                    UserName = a.UserName,
                    Status = a.Status,
                })
                .FirstOrDefault();
            return account;
        }

        //Change account status (Activate/Deactivate)
        public (string, bool) ChangeAccountStatus(Guid accId)
        {
            var account = _context.Account.Where(a => a.UserId == accId).FirstOrDefault();
            if (account == null) return ("Account not found.", false);
            if (account.Status == 'A') account.Status = 'D';
            else account.Status = 'A';
            try
            {
                _context.Update(account);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                return ("Unable to Change Account Status.\nError: " + ex.Message, false);
            }
            var msg = account.Status == 'A' ? "Account Activated Successfully." : "Account Deactivated Successfully.";
            return (msg, true);
        }

    }
}