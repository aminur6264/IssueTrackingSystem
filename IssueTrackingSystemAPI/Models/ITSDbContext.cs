using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using IssueTrackingSystemCL.Entity;

namespace IssueTrackingSystemAPI.Models
{
    public class ITSDbContext:DbContext
    {
        public DbSet<Issue> Issues { get; set; }
    }
}