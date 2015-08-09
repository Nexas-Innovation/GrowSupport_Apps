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
    public class M_HyokaGroupController : Controller
    {
        private GrowUpNaviDB db = new GrowUpNaviDB();

        // GET: M_HyokaGroup
        public ActionResult Index()
        {
            return View(db.M_HyokaGroup.ToList());
        }

        // GET: M_HyokaGroup/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            M_HyokaGroup m_HyokaGroup = db.M_HyokaGroup.Find(id);
            if (m_HyokaGroup == null)
            {
                return HttpNotFound();
            }
            return View(m_HyokaGroup);
        }

        // GET: M_HyokaGroup/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: M_HyokaGroup/Create
        // 過多ポスティング攻撃を防止するには、バインド先とする特定のプロパティを有効にしてください。
        // 詳細については、http://go.microsoft.com/fwlink/?LinkId=317598 を参照してください。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "HyokaNendo,HyokaGroupCd,HyokaGroupName,HierarchyLevel,DisplayOrder,DelFlg,CrtShainCd,CrtDt,CrtPlgId,LastUpdShainCd,LastUpdDt,LastUpdPlgId,RowVersion")] M_HyokaGroup m_HyokaGroup)
        {
            if (ModelState.IsValid)
            {
                db.M_HyokaGroup.Add(m_HyokaGroup);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(m_HyokaGroup);
        }

        // GET: M_HyokaGroup/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            M_HyokaGroup m_HyokaGroup = db.M_HyokaGroup.Find(id);
            if (m_HyokaGroup == null)
            {
                return HttpNotFound();
            }
            return View(m_HyokaGroup);
        }

        // POST: M_HyokaGroup/Edit/5
        // 過多ポスティング攻撃を防止するには、バインド先とする特定のプロパティを有効にしてください。
        // 詳細については、http://go.microsoft.com/fwlink/?LinkId=317598 を参照してください。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "HyokaNendo,HyokaGroupCd,HyokaGroupName,HierarchyLevel,DisplayOrder,DelFlg,CrtShainCd,CrtDt,CrtPlgId,LastUpdShainCd,LastUpdDt,LastUpdPlgId,RowVersion")] M_HyokaGroup m_HyokaGroup)
        {
            if (ModelState.IsValid)
            {
                db.Entry(m_HyokaGroup).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(m_HyokaGroup);
        }

        // GET: M_HyokaGroup/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            M_HyokaGroup m_HyokaGroup = db.M_HyokaGroup.Find(id);
            if (m_HyokaGroup == null)
            {
                return HttpNotFound();
            }
            return View(m_HyokaGroup);
        }

        // POST: M_HyokaGroup/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            M_HyokaGroup m_HyokaGroup = db.M_HyokaGroup.Find(id);
            db.M_HyokaGroup.Remove(m_HyokaGroup);
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
