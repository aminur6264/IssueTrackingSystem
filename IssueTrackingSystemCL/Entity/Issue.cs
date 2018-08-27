using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Build.Framework;

namespace IssueTrackingSystemCL.Entity
{
    public class Issue
    {
        public int Id { get; set; }
        public string Title { get; set; }
        [Required]
        public string Details { get; set; }
        public DateTime CreateDate { get; set; }
        public int CreateBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public int ModifiBy { get; set; }

        // Have to add navigation to user
    }
}
