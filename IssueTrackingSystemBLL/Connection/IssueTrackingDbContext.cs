using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IssueTrackingSystemBLL.Configrations;
using IssueTrackingSystemCL.Entity;

namespace IssueTrackingSystemBLL.Connection
{
    public class IssueTrackingDbContext:DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Module> Modules { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<ProjectModules> ProjectModuleses { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new UserConfigration());
            modelBuilder.Configurations.Add(new CustomerConfigration());
            modelBuilder.Configurations.Add(new ModuleConfigration());
            modelBuilder.Configurations.Add(new ProjectConfigration());
            modelBuilder.Configurations.Add(new ProjectModulesConfigration());
        }
    }
}
