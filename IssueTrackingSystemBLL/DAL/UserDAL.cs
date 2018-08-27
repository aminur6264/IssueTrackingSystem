using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using IssueTrackingSystemBLL.Connection;
using IssueTrackingSystemCL.Entity;

namespace IssueTrackingSystemBLL.DAL
{
    public class UserDAL
    {
        IssueTrackingDbContext db = new IssueTrackingDbContext();



        public User Login(string userName, string password)
        {
            User user = db.Users.FirstOrDefault(x=> x.Password == password && (x.UserName == userName || x.Email == userName) && x.IsActive==true);
            return user;
        }



        public object GetAllUser()
        {
            var result = db.Users.Select(x => new
            {
                Name = x.Name,
                AddedOn = x.AddDate
            }).ToList();
            return result;
        }

        public User GetCustomerById(int id)
        {
            var result = db.Users.FirstOrDefault(x => x.UserId == id);
            return result;
        }

        public string SaveOrUpdate(User user)
        {
            try
            {
                string message = "";
                if (user.UserId == 1)
                {
                    db.Users.Add(user);
                    message = "Data save.";
                }
                else
                {
                    db.Entry(user).State = EntityState.Modified;
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
