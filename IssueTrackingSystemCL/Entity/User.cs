using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IssueTrackingSystemCL.Entity
{
    public class User
    {
        public int UserId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }

        public ICollection<Customer> Customers { get; set; }
        public ICollection<Project> Projects { get; set; }
        //public ICollection<Module> Modules{ get; set; }
    }
}
