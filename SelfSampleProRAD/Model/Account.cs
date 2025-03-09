using System.ComponentModel.DataAnnotations;

namespace SelfSampleProRAD_DB.Model
{
    public class Account
    {
        //Auto-Properties
        [Key]
        [Required]
        public Guid UserId { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public char Status { get; set; }

        // Navigation property
        public virtual Employee Employee { get; set; }

        //Constructors
        public Account() { UserId = Guid.NewGuid(); }
    }
}
