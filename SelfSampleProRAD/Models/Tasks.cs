namespace SelfSampleProRAD_DB_SQL.Models
{
    public class Tasks
    {
        //Auto-Properties
        public Guid TaskId { get; set; }
        public string TaskName { get; set; }
        public string AssignedTo { get; set; }
        public string AssignedBy { get; set; }
        public char Status { get; set; }
        //Constructors
        public Tasks() { TaskId = Guid.NewGuid();}
    }
}
