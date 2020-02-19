using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ColorRoomManager.Models;

namespace ColorRoomManager.Controllers
{
    public class OperatorController : Controller
    {
        DBContext db = new DBContext();
        // GET: Operator
        public ActionResult Index()
        {
            var lst = db.Operators.ToList();
            if (lst.Count > 0)
            {
                return View(lst);
            }
            return View();
        }

        public JsonResult OperatorAdd(Operator models)
        {
            int status = 0;

            if (models != null)
            {
                var checkData = db.Operators.FirstOrDefault(x => x.OperatorCode == models.OperatorCode);
                if (checkData != null)
                {
                    status = -1;
                }

                Operator anoperator     = new Operator();
                anoperator.OperatorCode = models.OperatorCode;
                anoperator.OperatorName = models.OperatorName;
                anoperator.IsActive     = models.IsActive;
                anoperator.CreateBy     = User.Identity.Name;
                anoperator.CreateTime   = DateTime.Now;

                try
                {
                    db.Operators.Add(anoperator);
                    db.SaveChanges();
                    status = 1;
                }
                catch (Exception ex)
                {
                    ex.ToString();
                }
            }
            return Json(status, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public ActionResult OperatorUp(string Id)
        {
            var data = db.Operators.FirstOrDefault(x => x.OperatorCode == Id);
            if (data != null)
            {
                return PartialView("/Views/Operator/_OperatorUp.cshtml", data);
            }
            return View("Index");
            //return RedirectToAction("Index");
        }

        public JsonResult OperatorUp(Operator models)
        {
            bool status = false;
            if (models != null)
            {
                var data = db.Operators.FirstOrDefault(x => x.OperatorCode == models.OperatorCode);
                if (data != null)
                {
                    data.OperatorName = models.OperatorName;
                    data.IsActive = models.IsActive;
                    data.CreateBy = User.Identity.Name;
                    data.CreateTime = DateTime.Now;

                    try
                    {
                        db.SaveChanges();
                        status = true;
                    }
                    catch (Exception ex)
                    {
                        ex.ToString();
                    }
                }

            }
            return Json(status, JsonRequestBehavior.AllowGet);
        }

        public ActionResult OperatorDel(string Id)
        {
            var data = db.Operators.FirstOrDefault(x => x.OperatorCode == Id);
            if (data != null)
            {
                try
                {
                    db.Operators.Remove(data);
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    ex.ToString();
                }
            }
            return RedirectToAction("Index");
        }
    }
}