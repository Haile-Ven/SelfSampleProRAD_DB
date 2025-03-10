﻿using SelfSampleProRAD_DB.DTOs;
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
        public (EmployeeDTO, string) Login(string userNm, string pass)
        {
            var account = _context.Account
                .Include(a => a.Employee)
                .Where(a => a.UserName == userNm && a.Password == pass)
                .Select(ac => new EmployeeDTO()
                {
                    EmployeeId = ac.Employee.EmployeeId,
                    FirstName = ac.Employee.FirstName,
                    LastName = ac.Employee.LastName,
                    Gender = ac.Employee.Gender,
                    Age = ac.Employee.Age,
                    Position = ac.Employee.Position,
                    Salary = ac.Employee.Salary,
                    Tax = ac.Employee.Tax,
                    Catagory = ac.Employee.Catagory,
                    accountdto = new AccountDTO()
                    {
                        UserId = ac.UserId,
                        UserName = ac.UserName,
                        Status = ac.Status
                    }
                })
                .FirstOrDefault();
            if (account == null) return (null, "Invalid Username or Password.");
            if(account.accountdto.Status == 'D') return (null, "Account is deactivated.");

            return (account, "Login Successful.");
        }

        //Logout
        // implement this method here

        //Change password
        public string changePassword(Guid accountId, string oldPass, string newPass)
        {
            try
            {
                var account = _context.Account.Where(a => a.UserId == accountId).FirstOrDefault();
                if (account == null) return "Account not found.";
                if(account.Password != oldPass) return "Old Password is incorrect.";
                _context.Update(account);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to Change Password.\nError: " + ex.InnerException.Message);
                return "Unable to Change Password.\nError: " + ex.InnerException.Message;
            }
            return "Password Changed Successfully.";
        }

        //List all accounts
        public List<AccountDTO> ListAllAccounts()
        {
            var accounts = _context.Account
                .Select (a => new AccountDTO() 
                {
                    UserId = a.UserId,
                    UserName = a.UserName,
                    Status = a.Status,
                })
                .ToList();
            return accounts;
        }

        public List<AccountDTO> ListAllDevs()
        {
            var devs = _context.Account
                .Where(a => a.Employee.Position == "Developer")
                .Select(a => new AccountDTO()
                {
                    UserId = a.UserId,
                    UserName = a.UserName,
                    Status = a.Status,
                })
                .ToList();
            return devs;
        }

        //Change account status (Activate/Deactivate)
        public string ChangeAccountStatus(Guid accId)
        {
            var account = _context.Account.Where(a => a.UserId == accId).FirstOrDefault();
            if (account == null) return "Account not found.";
            if (account.Status == 'A') account.Status = 'D';
            else account.Status = 'A';
            try
                {
                    _context.Update(account);
                    _context.SaveChanges();
                }
                catch (Exception ex)
                {
                    return "Unable to Change Account Status.\nError: " + ex.InnerException.Message;
                }
            var msg = account.Status == 'A' ? "Account Activated Successfully." : "Account Deactivated Successfully.";
            return msg;
        }

    }
}
