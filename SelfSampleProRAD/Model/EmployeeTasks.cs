using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SelfSampleProRAD_DB.Model
{
    public class EmployeeTasks
    {
        [Key]
        [Required]
        public Guid ETID { get; set; }

        [Required]
        public Guid TaskId { get; set; }

        [Required]
        public Guid AssignedToId { get; set; }

        [Required]
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
