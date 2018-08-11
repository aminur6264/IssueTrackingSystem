using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IssueTrackingSystemCL.Entity;

namespace IssueTrackingSystemBLL.Configrations
{
    public class UserConfigration:EntityTypeConfiguration<User>
    {
        public UserConfigration()
        {
            Property(x => x.Name).IsRequired().HasMaxLength(30);

            
        }
    }
}
