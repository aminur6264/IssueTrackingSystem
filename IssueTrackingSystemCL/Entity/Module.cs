﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IssueTrackingSystemCL.Entity
{
    public class Module
    {
        public int ModuleId { get; set; }
        [Required]
        public string Name { get; set; }
        public DateTime AddedDate { get; set; }
        public int AddedBy { get; set; }

        //public User User { get; set; }
        public ICollection<ProjectModules> ProjectModuleses { get; set; }
    }
}
