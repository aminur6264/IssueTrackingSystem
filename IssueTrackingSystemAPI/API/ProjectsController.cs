using System;
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
            if (result == true)
                return Ok("Save Successfully");
            else
                return BadRequest("An Error Happen");
        }

        // POST: api/Projects
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Projects/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Projects/5
        public void Delete(int id)
        {
        }
    }
}
