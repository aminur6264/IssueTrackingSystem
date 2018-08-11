using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IssueTrackingSystemCL.Entity
{
    public class ProjectModules
    {
        public int ProjectId { get; set; }
        public int ModuleId { get; set; }

        //Navigation
        public Module Module { get; set; }
        public Project Project { get; set; }
    }
}
