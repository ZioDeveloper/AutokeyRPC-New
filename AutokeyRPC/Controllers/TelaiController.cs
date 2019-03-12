using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using AutokeyRPC.Models;

namespace AutokeyRPC.Controllers
{
    public class TelaiController : Controller
    {
        private AutokeyEntities db = new AutokeyEntities();

        // GET: Telai
        public ActionResult Index()
        {
            var rPC_Telai = db.RPC_Telai.Include(r => r.AUK_cantieri).Include(r => r.RPC_Lotti).Include(r => r.RPC_Telai1).Include(r => r.RPC_Telai2).Include(r => r.PKT_Operatori);
            return View(rPC_Telai.ToList());
        }

        // GET: Telai/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RPC_Telai rPC_Telai = db.RPC_Telai.Find(id);
            if (rPC_Telai == null)
            {
                return HttpNotFound();
            }
            return View(rPC_Telai);
        }

        // GET: Telai/Create
        public ActionResult Create()
        {
            ViewBag.IDCantiere = new SelectList(db.AUK_cantieri, "ID", "Codice");
            ViewBag.IDLotto = new SelectList(db.RPC_Lotti, "ID", "Note");
            ViewBag.ID = new SelectList(db.RPC_Telai, "ID", "IDOperatore");
            ViewBag.ID = new SelectList(db.RPC_Telai, "ID", "IDOperatore");
            ViewBag.IDOperatore = new SelectList(db.PKT_Operatori, "ID", "ID");
            return View();
        }

        // POST: Telai/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,IDCantiere,IDOperatore,IDLotto,IsFinished,InsertDate,Telaio,Descr")] RPC_Telai rPC_Telai)
        {
            if (ModelState.IsValid)
            {
                db.RPC_Telai.Add(rPC_Telai);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.IDCantiere = new SelectList(db.AUK_cantieri, "ID", "Codice", rPC_Telai.IDCantiere);
            ViewBag.IDLotto = new SelectList(db.RPC_Lotti, "ID", "Note", rPC_Telai.IDLotto);
            ViewBag.ID = new SelectList(db.RPC_Telai, "ID", "IDOperatore", rPC_Telai.ID);
            ViewBag.ID = new SelectList(db.RPC_Telai, "ID", "IDOperatore", rPC_Telai.ID);
            ViewBag.IDOperatore = new SelectList(db.PKT_Operatori, "ID", "ID", rPC_Telai.IDOperatore);
            return View(rPC_Telai);
        }

        // GET: Telai/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RPC_Telai rPC_Telai = db.RPC_Telai.Find(id);
            if (rPC_Telai == null)
            {
                return HttpNotFound();
            }
            ViewBag.IDCantiere = new SelectList(db.AUK_cantieri, "ID", "Codice", rPC_Telai.IDCantiere);
            ViewBag.IDLotto = new SelectList(db.RPC_Lotti, "ID", "Note", rPC_Telai.IDLotto);
            ViewBag.ID = new SelectList(db.RPC_Telai, "ID", "IDOperatore", rPC_Telai.ID);
            ViewBag.ID = new SelectList(db.RPC_Telai, "ID", "IDOperatore", rPC_Telai.ID);
            ViewBag.IDOperatore = new SelectList(db.PKT_Operatori, "ID", "ID", rPC_Telai.IDOperatore);
            return View(rPC_Telai);
        }

        // POST: Telai/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,IDCantiere,IDOperatore,IDLotto,IsFinished,InsertDate,Telaio,Descr")] RPC_Telai rPC_Telai)
        {
            if (ModelState.IsValid)
            {
                db.Entry(rPC_Telai).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.IDCantiere = new SelectList(db.AUK_cantieri, "ID", "Codice", rPC_Telai.IDCantiere);
            ViewBag.IDLotto = new SelectList(db.RPC_Lotti, "ID", "Note", rPC_Telai.IDLotto);
            ViewBag.ID = new SelectList(db.RPC_Telai, "ID", "IDOperatore", rPC_Telai.ID);
            ViewBag.ID = new SelectList(db.RPC_Telai, "ID", "IDOperatore", rPC_Telai.ID);
            ViewBag.IDOperatore = new SelectList(db.PKT_Operatori, "ID", "ID", rPC_Telai.IDOperatore);
            return View(rPC_Telai);
        }

        // GET: Telai/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RPC_Telai rPC_Telai = db.RPC_Telai.Find(id);
            if (rPC_Telai == null)
            {
                return HttpNotFound();
            }
            return View(rPC_Telai);
        }

        // POST: Telai/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            RPC_Telai rPC_Telai = db.RPC_Telai.Find(id);
            db.RPC_Telai.Remove(rPC_Telai);
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
