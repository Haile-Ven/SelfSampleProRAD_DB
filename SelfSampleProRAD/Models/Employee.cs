namespace SelfSampleProRAD_DB_SQL.Models
{
    public class Employee
    {
        //Auto-properties
        public Guid EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public char Gender { get; set; }
        public byte Age { get; set; }
        public string Position { get; set; }
        public float Salary { get; set; }
        public float Tax { get; set; }
        public string Category { get; set; }
        public Guid? UserId {  get; set; }
        //Navigation property for Account
        public Account? Account { get; set; }
        //Constructors
        public Employee() { EmployeeId = Guid.NewGuid(); }
    }
}
