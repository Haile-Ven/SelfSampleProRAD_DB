namespace SelfSampleProRAD_DB_SQL.DTOs
{
    internal class EmployeeCreateDTO
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public char Gender { get; set; }
        public byte Age { get; set; }
        public string Position { get; set; }
        public string Category { get; set; }
    }
}
