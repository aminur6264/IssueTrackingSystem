using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using IssueTrackingSystemBLL.DAL;

namespace IssueTrackingSystemAPI.API
{
    public class UserController : ApiController
    {
        private  readonly UserDAL _userDal = new UserDAL();
        // GET: api/User
        public IHttpActionResult Login(string userName,string password)
        {
            var user = _userDal.Login(userName, password);
            if (user != null)
                return Ok(user);
            else
                return BadRequest("UserName or Password not currect");
        }

        // GET: api/User/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/User
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/User/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/User/5
        public void Delete(int id)
        {
        }
    }
}
