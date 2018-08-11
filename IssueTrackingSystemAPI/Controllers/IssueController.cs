using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using IssueTrackingSystemCL.Entity;

namespace IssueTrackingSystemAPI.Controllers
{
    public class IssueController : ApiController
    {
        // GET: api/Issue
        public IHttpActionResult Get()
        {
            return Ok();
        }

        // GET: api/Issue/5
        public IHttpActionResult Get(int id)            
        {
            return Ok();
        }

        // POST: api/Issue
        public IHttpActionResult SaveIssue([FromBody]Issue issue)
        {
            return Ok();
        }

        // PUT: api/Issue/5
        public IHttpActionResult Put(int id, [FromBody]string value)
        {
            return Ok();
        }

        // DELETE: api/Issue/5
        public IHttpActionResult Delete(int id)
        {
          return  Ok();
        }
    }
}
