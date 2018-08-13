using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IssueTrackingSystemBLL.Connection;
using IssueTrackingSystemCL.Entity;

namespace IssueTrackingSystemBLL.DAL
{
    public class ProjectDAL
    {
        IssueTrackingDbContext db = new IssueTrackingDbContext();

        public object GetAllProject()
        {
            var result = db.Projects.Select(x => new
            {
                Name = x.Name,
                AddedOn = x.AddedDate,
                AddedBy = x.User.Name
            }).ToList();
            return result;
        }

        public bool SaveOrUpdate(Project project)
        {
            try
            {
                if (project.ProjectId == 1)
                {
                    db.Projects.Add(project);
                }
                else
                {
                    db.Entry(project).State = EntityState.Modified;
                }
                
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
