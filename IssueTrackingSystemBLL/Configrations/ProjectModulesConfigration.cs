using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IssueTrackingSystemCL.Entity;

namespace IssueTrackingSystemBLL.Configrations
{
    public class ProjectModulesConfigration:EntityTypeConfiguration<ProjectModules>
    {
        public ProjectModulesConfigration()
        {

            HasKey(p => new {p.ProjectId, p.ModuleId});

            HasRequired(x=>x.Project)
                .WithMany(y=>y.ProjectModuleses)
                .HasForeignKey(p=>p.ProjectId)
                .WillCascadeOnDelete(true);

            HasRequired(x=>x.Module)
                .WithMany(y=>y.ProjectModuleses)
                .HasForeignKey(p=>p.ModuleId)
                .WillCascadeOnDelete(true);
        }
    }
}
