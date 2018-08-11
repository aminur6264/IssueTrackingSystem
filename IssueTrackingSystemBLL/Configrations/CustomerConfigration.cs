using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IssueTrackingSystemCL.Entity;

namespace IssueTrackingSystemBLL.Configrations
{
    public class CustomerConfigration: EntityTypeConfiguration<Customer>
    {
        public CustomerConfigration()
        {
            HasRequired(x => x.User)
                .WithMany(y => y.Customers)
                .HasForeignKey(p => p.AddedBy)
                .WillCascadeOnDelete(true);
        }
    }
}
