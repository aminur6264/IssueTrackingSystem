using IssueTrackingSystemBLL.Connection;
using IssueTrackingSystemCL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace IssueTrackingSystemBLL.DAL
{
    public class CustomerDAL
    {
        IssueTrackingDbContext db = new IssueTrackingDbContext();

        public object GetAllCustomer()
        {
            var result = db.Customers.Select(x => new
            {
                Name = x.Name,
                AddedOn = x.AddDate,
                AddedBy = x.User.Name
            }).ToList();
            return result;
        }

        public Customer GetCustomerById(int id)
        {
            var result = db.Customers.FirstOrDefault(x => x.CustomerId == id);
            return result;
        }

        public string SaveOrUpdate(Customer customer)
        {
            try
            {
                string message = "";
                if (customer.CustomerId == 1)
                {
                    db.Customers.Add(customer);
                    message = "Data save.";
                }
                else
                {
                    db.Entry(customer).State = EntityState.Modified;
                    message = "Data Updated.";
                }

                db.SaveChanges();
                return message;
            }
            catch (Exception)
            {
                return "Some Thing is wrong!!!";
            }
        }

    }
}
