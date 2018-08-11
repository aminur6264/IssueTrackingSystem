using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IssueTrackingSystemCL.Entity;

namespace IssueTrackingSystemBLL.Configrations
{
    public class ProjectConfigration: EntityTypeConfiguration<Project>
    {
        public ProjectConfigration()
        {
            HasRequired(x => x.User)
                .WithMany(y => y.Projects)
                .HasForeignKey(p => p.AddedBy)
                .WillCascadeOnDelete(true);
        }
    }
}
