using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models.EFModels;
using WebApplication1.Models.Services;
using WebApplication1.Services;

namespace WebApplication1.Controllers
{
    public class RegistersController : Controller
    {
        private IRegisterRepository repository;
        public RegistersController()
        {
            repository = new RegisterRepository();
        }

        public ActionResult Index()
        {
            var data = new RegisterRepository().GetAll();
            return View(data);
        }

        // GET: Registers/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            try { 
                Register register = new RegisterService().Find(id.Value);
                return View(register);
            }
            catch(Exception ex) {
                return HttpNotFound();
            }
            
        }

        // GET: Registers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Registers/Create
        // 若要避免過量張貼攻擊，請啟用您要繫結的特定屬性。
        // 如需詳細資料，請參閱 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Email")] Register register)
        {
            try
            {
                new RegisterService().Create(register);
            }
            catch (Exception ex)
            {
                ModelState.AddModelError(string.Empty, ex.Message);
            }
           

            if (ModelState.IsValid)
            {               
                return RedirectToAction("Index");
            }

            return View(register);
        }

        // GET: Registers/Edit/5
        //public ActionResult Edit(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    Register register = db.Registers.Find(id);
        //    if (register == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(register);
        //}

        // POST: Registers/Edit/5
        // 若要避免過量張貼攻擊，請啟用您要繫結的特定屬性。
        // 如需詳細資料，請參閱 https://go.microsoft.com/fwlink/?LinkId=317598。
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit([Bind(Include = "Id,Name,Email,CreateTime")] Register register)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.Entry(register).State = EntityState.Modified;
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }
        //    return View(register);
        //}

        // GET: Registers/Delete/5
        //public ActionResult Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    Register register = db.Registers.Find(id);
        //    if (register == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(register);
        //}

        //// POST: Registers/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public ActionResult DeleteConfirmed(int id)
        //{
        //    Register register = db.Registers.Find(id);
        //    db.Registers.Remove(register);
        //    db.SaveChanges();
        //    return RedirectToAction("Index");
        //}

        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing)
        //    {
        //        db.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}
    }
}
