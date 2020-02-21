using ColorRoomManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ColorRoomManager.Controllers
{
    public class LossTypeController : Controller
    {
        DBContext db = new DBContext();
        // GET: LossType
        public ActionResult Index()
        {
            var lst = db.LossTypes.ToList();
            if (lst.Count > 0)
            {
                return View(lst);
            }
            return View();
        }

        public JsonResult LossTypeAdd(LossType models)
        {
            int status = 0;

            if (models != null)
            {
                var checkData = db.LossTypes.FirstOrDefault(x => x.Id == models.Id);
                if (checkData != null)
                {
                    status = -1;
                }

                LossType lossType     = new LossType();
                lossType.LossTypeName = models.LossTypeName;
                lossType.IsActive     = models.IsActive;
                lossType.CreateBy     = User.Identity.Name;
                lossType.CreateTime   = DateTime.Now;

                try
                {
                    db.LossTypes.Add(lossType);
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
        public ActionResult LossTypeUp(int? Id)
        {
            var data = db.LossTypes.FirstOrDefault(x => x.Id == Id);
            if (data != null)
            {
                return PartialView("/Views/LossType/_LossTypeUp.cshtml", data);
            }
            //return View("Index");
            return RedirectToAction("Index");
        }

        [HttpPost]
        public JsonResult LossTypeUp(LossType models)
        {
            bool status = false;

            if (models != null)
            {
                var data = db.LossTypes.FirstOrDefault(x => x.Id == models.Id);
                if (data != null)
                {
                    data.LossTypeName = models.LossTypeName;
                    data.IsActive     = models.IsActive;
                    data.CreateBy     = User.Identity.Name;
                    data.CreateTime   = DateTime.Now;

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

        public ActionResult LossTypeDel(int? Id)
        {
            var data = db.LossTypes.FirstOrDefault(x => x.Id == Id);
            if (data != null)
            {
                try
                {
                    db.LossTypes.Remove(data);
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