﻿using System;
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

        public Project GetProjectById(int id)
        {
            var result = db.Projects.FirstOrDefault(x => x.ProjectId == id);
            return result;
        }

        public string SaveOrUpdate(Project project)
        {
            try
            {
                string message = "";
                if (project.ProjectId == 1)
                {
                    db.Projects.Add(project);
                    message = "Data save.";
                }
                else
                {
                    db.Entry(project).State = EntityState.Modified;
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
