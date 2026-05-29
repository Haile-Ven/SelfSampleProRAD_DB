namespace SelfSampleProRAD_DB_SQL.Models
{
    class EmployeeTasks
    {

        public Guid ETID { get; set; }
        public Guid TaskId { get; set; }
        public Guid AssignedToId { get; set; }
        public Guid AssignedById { get; set; }
        public EmployeeTasks()
        {
            ETID = Guid.NewGuid();
        }
    }
}
