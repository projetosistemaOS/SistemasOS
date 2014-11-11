using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SistemaOSMVC.Models;

namespace SistemaOSMVC.Controllers
{
    public class AndamentoOSController : Controller
    {
        private dbSistemaOSEntities1 db = new dbSistemaOSEntities1();

        // GET: /AndamentoOS/
        public ActionResult Index()
        {
            return View(db.AndamentoOS.ToList());
        }

        // GET: /AndamentoOS/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AndamentoOS andamentoos = db.AndamentoOS.Find(id);
            if (andamentoos == null)
            {
                return HttpNotFound();
            }
            return View(andamentoos);
        }

        // GET: /AndamentoOS/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /AndamentoOS/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="IdAndamentoOS,Nome")] AndamentoOS andamentoos)
        {
            if (ModelState.IsValid)
            {
                db.AndamentoOS.Add(andamentoos);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(andamentoos);
        }

        // GET: /AndamentoOS/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AndamentoOS andamentoos = db.AndamentoOS.Find(id);
            if (andamentoos == null)
            {
                return HttpNotFound();
            }
            return View(andamentoos);
        }

        // POST: /AndamentoOS/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="IdAndamentoOS,Nome")] AndamentoOS andamentoos)
        {
            if (ModelState.IsValid)
            {
                db.Entry(andamentoos).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(andamentoos);
        }

        // GET: /AndamentoOS/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AndamentoOS andamentoos = db.AndamentoOS.Find(id);
            if (andamentoos == null)
            {
                return HttpNotFound();
            }
            return View(andamentoos);
        }

        // POST: /AndamentoOS/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            AndamentoOS andamentoos = db.AndamentoOS.Find(id);
            db.AndamentoOS.Remove(andamentoos);
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
