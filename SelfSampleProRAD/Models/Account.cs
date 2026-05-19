namespace SelfSampleProRAD_DB_SQL.Models
{
    public class Account
    {
        public Guid UserID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public char Status { get; set; }

        public Employee Employee { get; set; }

        public Account() { UserID = Guid.NewGuid(); }
    }
}
