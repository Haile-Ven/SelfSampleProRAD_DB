using Microsoft.EntityFrameworkCore;
using SelfSampleProRAD_DB.Model;
namespace SelfSampleProRAD_DB.Controller
{
    class AccountController
    {
        private readonly AppDbContext _context;

        public AccountController(AppDbContext context)
        {
            _context = context;
        }
        //public void createAccount(string fName, string lName, string pass, string pos)
        //{

        //    Account acc = new Account
        //    {
        //        UserId = new Guid(),
        //        UserName = string.Format($"{lName}_{fName}@{}")
        //    };
        //}
        //public byte changePassword(string oldPass, string newPass)
        //{

        //}
        //public SqlDataReader ListAllAccounts()
        //{

        //}
        //public SqlDataReader ListAllDevs()
        //{

        //}
        //public byte activateAccount(string userNm)
        //{

        //}
        //public byte deactivateAccount(string userNm)
        //{

        //}
    }
}
