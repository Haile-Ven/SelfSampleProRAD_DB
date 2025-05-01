using SelfSampleProRAD_DB_SQL.Models;
using System.ComponentModel.DataAnnotations;

namespace SelfSampleProRAD_DB_SQL.Controllers
{
    class EmployeeTasksController
    {

        public Guid ETID { get; set; }
        public Guid TaskId { get; set; }
        public Guid AssignedToId { get; set; }
        public Guid AssignedById { get; set; }

        // Navigation properties
        public virtual Employee AssignedTo { get; set; }
        public virtual Employee AssignedBy { get; set; }
        public virtual Tasks Tasks { get; set; }

        public EmployeeTasksController()
        {
            ETID = Guid.NewGuid();
        }
    }
}
