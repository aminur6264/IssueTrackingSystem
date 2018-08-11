using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using IssueTrackingSystemBLL.Connection;
using IssueTrackingSystemCL.Entity;

namespace IssueTrackingSystemAPP.Controllers
{
    public class ProjectModulesController : Controller
    {
        private IssueTrackingDbContext db = new IssueTrackingDbContext();

        // GET: ProjectModules
        public ActionResult Index()
        {
            var projectModuleses = db.ProjectModuleses.Include(p => p.Module).Include(p => p.Project);
            return View(projectModuleses.ToList());
        }

        // GET: ProjectModules/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProjectModules projectModules = db.ProjectModuleses.Find(id);
            if (projectModules == null)
            {
                return HttpNotFound();
            }
            return View(projectModules);
        }

        // GET: ProjectModules/Create
        public ActionResult Create()
        {
            ViewBag.ModuleId = new SelectList(db.Modules, "ModuleId", "Name");
            ViewBag.ProjectId = new SelectList(db.Projects, "ProjectId", "Name");
            return View();
        }

        // POST: ProjectModules/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ProjectId,ModuleId")] ProjectModules projectModules)
        {
            if (ModelState.IsValid)
            {
                db.ProjectModuleses.Add(projectModules);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ModuleId = new SelectList(db.Modules, "ModuleId", "Name", projectModules.ModuleId);
            ViewBag.ProjectId = new SelectList(db.Projects, "ProjectId", "Name", projectModules.ProjectId);
            return View(projectModules);
        }

        // GET: ProjectModules/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProjectModules projectModules = db.ProjectModuleses.Find(id);
            if (projectModules == null)
            {
                return HttpNotFound();
            }
            ViewBag.ModuleId = new SelectList(db.Modules, "ModuleId", "Name", projectModules.ModuleId);
            ViewBag.ProjectId = new SelectList(db.Projects, "ProjectId", "Name", projectModules.ProjectId);
            return View(projectModules);
        }

        // POST: ProjectModules/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ProjectId,ModuleId")] ProjectModules projectModules)
        {
            if (ModelState.IsValid)
            {
                db.Entry(projectModules).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ModuleId = new SelectList(db.Modules, "ModuleId", "Name", projectModules.ModuleId);
            ViewBag.ProjectId = new SelectList(db.Projects, "ProjectId", "Name", projectModules.ProjectId);
            return View(projectModules);
        }

        // GET: ProjectModules/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProjectModules projectModules = db.ProjectModuleses.Find(id);
            if (projectModules == null)
            {
                return HttpNotFound();
            }
            return View(projectModules);
        }

        // POST: ProjectModules/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ProjectModules projectModules = db.ProjectModuleses.Find(id);
            db.ProjectModuleses.Remove(projectModules);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
