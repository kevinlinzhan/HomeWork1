using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using HomeWork1.Models;

namespace HomeWork1.Controllers
{
    public class CustomerReportController : Controller
    {
        private CustomerEntities db = new CustomerEntities();

        // GET: CustomerReport
        public ActionResult Index()
        {
            return View(db.VW_CustomerReport.ToList());
        }

        // GET: CustomerReport/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VW_CustomerReport vW_CustomerReport = db.VW_CustomerReport.Find(id);
            if (vW_CustomerReport == null)
            {
                return HttpNotFound();
            }
            return View(vW_CustomerReport);
        }

        // GET: CustomerReport/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CustomerReport/Create
        // 若要免於過量張貼攻擊，請啟用想要繫結的特定屬性，如需
        // 詳細資訊，請參閱 http://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "客戶名稱,contactCounts,bankCounts,Id")] VW_CustomerReport vW_CustomerReport)
        {
            if (ModelState.IsValid)
            {
                db.VW_CustomerReport.Add(vW_CustomerReport);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(vW_CustomerReport);
        }

        // GET: CustomerReport/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VW_CustomerReport vW_CustomerReport = db.VW_CustomerReport.Find(id);
            if (vW_CustomerReport == null)
            {
                return HttpNotFound();
            }
            return View(vW_CustomerReport);
        }

        // POST: CustomerReport/Edit/5
        // 若要免於過量張貼攻擊，請啟用想要繫結的特定屬性，如需
        // 詳細資訊，請參閱 http://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "客戶名稱,contactCounts,bankCounts,Id")] VW_CustomerReport vW_CustomerReport)
        {
            if (ModelState.IsValid)
            {
                db.Entry(vW_CustomerReport).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(vW_CustomerReport);
        }

        // GET: CustomerReport/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VW_CustomerReport vW_CustomerReport = db.VW_CustomerReport.Find(id);
            if (vW_CustomerReport == null)
            {
                return HttpNotFound();
            }
            return View(vW_CustomerReport);
        }

        // POST: CustomerReport/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            VW_CustomerReport vW_CustomerReport = db.VW_CustomerReport.Find(id);
            db.VW_CustomerReport.Remove(vW_CustomerReport);
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
