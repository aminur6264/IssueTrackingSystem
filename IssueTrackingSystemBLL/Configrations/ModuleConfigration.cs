using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IssueTrackingSystemCL.Entity;

namespace IssueTrackingSystemBLL.Configrations
{
    public class ModuleConfigration:EntityTypeConfiguration<Module>
    {
        public ModuleConfigration()
        {
            //HasRequired(x => x.User)
            //    .WithMany(x => x.Modules)
            //    .HasForeignKey(p => p.AddedBy)
            //    .WillCascadeOnDelete(true);
        }
    }
}
