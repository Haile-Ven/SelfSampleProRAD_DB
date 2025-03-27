using SelfSampleProRAD_DB_SQL.Models;
using System.ComponentModel.DataAnnotations;

namespace SelfSampleProRAD_DB_SQL.Controllers
{
    class EmployeeTasks
    {
        
        public Guid ETID { get; set; }
        public Guid TaskId { get; set; }
        public Guid AssignedToId { get; set; }
        public Guid AssignedById { get; set; }

        // Navigation properties
        public virtual Employee AssignedTo { get; set; }
        public virtual Employee AssignedBy { get; set; }
        public virtual Tasks Tasks { get; set; }

        public EmployeeTasks()
        {
            ETID = Guid.NewGuid();
        }
    }
}
