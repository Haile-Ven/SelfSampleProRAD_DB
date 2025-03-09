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
        [ForeignKey("EmployeeId")]
        public Guid EmployeeId { get; set; }
        [Required]
        [ForeignKey("TaskId")]
        public Guid TaskId { get; set; }

        // Navigation property
        public virtual Employee Employees { get; set; }
        public virtual Tasks Tasks { get; set; }
        //Constructors
        public EmployeeTasks() { ETID = new Guid(); }
    }
}
