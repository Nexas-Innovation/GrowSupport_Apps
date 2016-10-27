using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using GrowUpNavi.Models.Entity;

namespace GrowUpNavi.Controllers
{
    public class M_YakushokuController : Controller
    {
        private GrowUpNaviDB db = new GrowUpNaviDB();

        // GET: M_Yakushoku
        public ActionResult Index()
        {
            return View(db.M_Yakushoku.ToList());
        }

        // GET: M_Yakushoku/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            M_Yakushoku m_Yakushoku = db.M_Yakushoku.Find(id);
            if (m_Yakushoku == null)
            {
                return HttpNotFound();
            }
            return View(m_Yakushoku);
        }

        // GET: M_Yakushoku/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: M_Yakushoku/Create
        // 過多ポスティング攻撃を防止するには、バインド先とする特定のプロパティを有効にしてください。
        // 詳細については、http://go.microsoft.com/fwlink/?LinkId=317598 を参照してください。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "YakushokuCd,Meisho,Ryakusho,HierarchyID,HierarchyLevel,DisplayOrder,DelFlg,CrtShainCd,CrtDt,CrtPlgId,LastUpdShainCd,LastUpdDt,LastUpdPlgId,RowVersion")] M_Yakushoku m_Yakushoku)
        {
            if (ModelState.IsValid)
            {
                db.M_Yakushoku.Add(m_Yakushoku);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(m_Yakushoku);
        }

        // GET: M_Yakushoku/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            M_Yakushoku m_Yakushoku = db.M_Yakushoku.Find(id);
            if (m_Yakushoku == null)
            {
                return HttpNotFound();
            }
            return View(m_Yakushoku);
        }

        // POST: M_Yakushoku/Edit/5
        // 過多ポスティング攻撃を防止するには、バインド先とする特定のプロパティを有効にしてください。
        // 詳細については、http://go.microsoft.com/fwlink/?LinkId=317598 を参照してください。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "YakushokuCd,Meisho,Ryakusho,HierarchyID,HierarchyLevel,DisplayOrder,DelFlg,CrtShainCd,CrtDt,CrtPlgId,LastUpdShainCd,LastUpdDt,LastUpdPlgId,RowVersion")] M_Yakushoku m_Yakushoku)
        {
            if (ModelState.IsValid)
            {
                db.Entry(m_Yakushoku).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(m_Yakushoku);
        }

        // GET: M_Yakushoku/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            M_Yakushoku m_Yakushoku = db.M_Yakushoku.Find(id);
            if (m_Yakushoku == null)
            {
                return HttpNotFound();
            }
            return View(m_Yakushoku);
        }

        // POST: M_Yakushoku/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            M_Yakushoku m_Yakushoku = db.M_Yakushoku.Find(id);
            db.M_Yakushoku.Remove(m_Yakushoku);
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
