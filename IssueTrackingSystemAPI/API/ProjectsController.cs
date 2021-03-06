﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using IssueTrackingSystemBLL.DAL;
using IssueTrackingSystemCL.Entity;

namespace IssueTrackingSystemAPI.API
{
    public class ProjectsController : ApiController
    {
        private readonly ProjectDAL _projectDal = new ProjectDAL();
        // GET: api/Projects
        public IHttpActionResult GetAllProject()
        {
            return Ok(_projectDal.GetAllProject());
        }

        [HttpPost]
        public IHttpActionResult SaveOrUpdate(Project project)
        {

            var result = _projectDal.SaveOrUpdate(project);
            return Ok("Save Successfully");
        }

        // DELETE: api/Projects/5
        public void Delete(int id)
        {
        }
    }
}
