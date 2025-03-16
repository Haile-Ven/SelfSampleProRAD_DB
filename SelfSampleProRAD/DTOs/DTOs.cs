using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfSampleProRAD_DB.DTOs
{
    public class AccountDTO
    {
        public Guid UserId { get; set; }
        public string UserName { get; set; }
        public char Status { get; set; }
    }

    public class EmployeeDTO
    {
        public Guid EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public char Gender { get; set; }
        public byte Age { get; set; }
        public string Position { get; set; }
        public float Salary { get; set; }
        public float Tax { get; set; }
        public string Catagory { get; set; }
        public AccountDTO accountdto { get; set; }
    }

    public class TaskViewByDTO
    {
        public string FullName { get; set; }
        public string TaskName { get; set; }
        public string Status { get; set; }
    }

    public class TaskViewToDTO
    {
        public Guid? TaskId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string TaskName { get; set; }
        public string Status { get; set; }
    }

}
