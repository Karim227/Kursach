using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Cyrsovay.Models;
using Microsoft.EntityFrameworkCore;

namespace Cyrsovay.Controllers
{
    public class HomeController : Controller
    {
        readonly BTGPContext db;

        public HomeController(BTGPContext context)
        {
            db = context;
        }
        public IActionResult Index()
        {
            return View(db.Cyrsach.ToList());
        }
        public IActionResult DB(string name, string id)
        {
            return View(db.Cyrsach.ToList());
        }

        [HttpGet]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }
            BTGPModel student = db.Cyrsach.Find(id);
            if (student != null)
            {

                return View(student);
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult Edit(BTGPModel student)
        {
            db.Entry(student).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Add(BTGPModel student)
        {
            db.Entry(student).State = EntityState.Added;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult DeleteS(int id)
        {
            BTGPModel s = new BTGPModel { Id = id };
            db.Entry(s).State = EntityState.Deleted;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Delete(int id)
        {
            BTGPModel del = db.Cyrsach.Find(id);
            if (del == null)
            {
                return HttpNotFound();
            }
            return View(del);
        }

        private ActionResult HttpNotFound()
        {
            throw new NotImplementedException();
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            BTGPModel b = db.Cyrsach.Find(id);
            if (b == null)
            {
                return HttpNotFound();
            }
            db.Cyrsach.Remove(b);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
