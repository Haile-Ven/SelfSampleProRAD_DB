namespace SelfSampleProRAD_DB_SQL.Models
{
    public class Tasks
    {
        public Guid TaskId { get; set; }
        public string TaskName { get; set; }
        public string AssignedTo { get; set; }
        public string AssignedBy { get; set; }
        public char Status { get; set; }
        public Tasks() { TaskId = Guid.NewGuid(); }
    }
}
