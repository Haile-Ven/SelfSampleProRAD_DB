using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SelfSampleProRAD_DB.Model
{
    public class Employee
    {
        //Auto-properties
        [Key]
        [Required]
        public Guid EmployeeId { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public char Gender { get; set; }
        [Required]
        public byte Age { get; set; }
        [Required]
        public string Position { get; set; }
        [Required]
        public float Salary { get; set; }
        [Required]
        public float Tax { get; set; }
        [Required]
        public string Catagory { get; set; }

        public Guid? UserId { get; set; }

        // Navigation property
        [ForeignKey("UserId")]
        public virtual Account Account { get; set; }
        public virtual ICollection<EmployeeTasks> EmployeeTasks { get; set; }
        
        //Constructors
        public Employee() { EmployeeId = Guid.NewGuid(); }
    }
}
