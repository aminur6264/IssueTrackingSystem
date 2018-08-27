using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using IssueTrackingSystemBLL.Connection;
using IssueTrackingSystemCL.Entity;
using IssueTrackingSystemBLL.DAL;

namespace IssueTrackingSystemAPI.API
{
    public class ModuleController : ApiController
    {
        private readonly ModuleDAL _moduleDAL = new ModuleDAL();

        [HttpGet]
        public IHttpActionResult GetAllModule()
        {
            return Ok(_moduleDAL.GetAllModule());
        }

        // GET: api/Module/5
        [ResponseType(typeof(Module))]
        public IHttpActionResult GetModuleById(int id)
        {
            Module module = _moduleDAL.GetModuleById(id);
            if (module == null)
            {
                return NotFound();
            }

            return Ok(module);
        }

        // PUT: api/Module/5
        [HttpPost]
        public IHttpActionResult SaveOrUpdate(Module module)
        {
           var message =  _moduleDAL.SaveOrUpdate(module);
            return Ok(message);
        }
       
    }
}