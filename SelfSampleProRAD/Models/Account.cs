namespace SelfSampleProRAD_DB_SQL.Models
{
    public class Account
    {
        //Auto-Properties
        public Guid UserID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public char Status { get; set; }
        
        // Navigation property for Employee
        public Employee Employee { get; set; }
        
        //Constructors
        public Account() { UserID = Guid.NewGuid(); }
    }
}
