using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using contact.Models;

namespace contact.Controllers
{
    public class TestDBModelsController : Controller
    {
        private Models.AppContext db = new Models.AppContext();

        // GET: TestDBModels
        public ActionResult Create()
        {
            return View();
        }

        // GET: TestDBModels/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TestDBModel testDBModel = db.TestDBModels.Find(id);
            if (testDBModel == null)
            {
                return HttpNotFound();
            }
            return View(testDBModel);
        }

        
        // POST: TestDBModels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create( TestDBModel testDBModel)
        {
            if (ModelState.IsValid)
            {
                db.TestDBModels.Add(testDBModel);
                db.SaveChanges();
                return RedirectToAction("Create");
            }

            return View(testDBModel);
        }

       

        // GET: TestDBModels/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TestDBModel testDBModel = db.TestDBModels.Find(id);
            if (testDBModel == null)
            {
                return HttpNotFound();
            }
            return View(testDBModel);
        }

        // POST: TestDBModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TestDBModel testDBModel = db.TestDBModels.Find(id);
            db.TestDBModels.Remove(testDBModel);
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
