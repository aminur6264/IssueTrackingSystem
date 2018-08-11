using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Build.Framework;

namespace IssueTrackingSystemCL.Entity
{
    public class Customer
    {
        public int CustomerId { get; set; }

        [Required]
        public string Name { get; set; }
        public string Address { get; set; }
        public DateTime AddDate { get; set; }
        public int AddedBy { get; set; }

        public User User { get; set; }
    }
}
