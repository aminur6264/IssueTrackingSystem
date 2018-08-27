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
    public class ModuleDAL
    {
        IssueTrackingDbContext db = new IssueTrackingDbContext();

        public object GetAllModule()
        {
            var modules = db.Modules.ToList();
            return modules;
        }
        public Module GetModuleById(int id)
        {
            var result = db.Modules.FirstOrDefault(x => x.ModuleId == id);
            return result;
        }
        public string SaveOrUpdate(Module module)
        {
            try
            {
                string message = "";
                if (module.ModuleId == 1)
                {
                    db.Modules.Add(module);
                    message = "Data save.";
                }
                else
                {
                    db.Entry(module).State = EntityState.Modified;
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
