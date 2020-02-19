using ColorRoomManager.Models;
using ColorRoomManager.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ColorRoomManager.Controllers
{
    public class ColorsController : Controller
    {

        DBContext db = new DBContext();
        // GET: Colors
        public ActionResult Index()
        {
            var lst = db.Colors.ToList();
            if (lst.Count > 0)
            {
                return View(lst);
            }
            return View();
        }

        public JsonResult ColorAdd(ColorViewModels models)
        {
            int status = 0;
            if (models != null)
            {
                var checkData = db.Colors.FirstOrDefault(x => x.ColorCode == models.ColorCode);
                if (checkData != null)
                {
                    status = -1;
                }

                Color color = new Color();
                color.ColorCode = models.ColorCode;
                color.ColorName = models.ColorName;
                color.IsActive = models.IsActive;
                color.CreateBy = User.Identity.Name;
                color.CreateTime = DateTime.Now;

                try
                {
                    db.Colors.Add(color);
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
        public ActionResult ColorUp(string Id)
        {
            var data = db.Colors.FirstOrDefault(x => x.ColorCode == Id);
            if (data != null)
            {
                return PartialView("/Views/Colors/_ColorUp.cshtml", data);
            }
            //return View("Index");
            return RedirectToAction("Index");
        }

        public JsonResult ColorUp(ColorViewModels models)
        {
            bool status = false;

            if (models != null)
            {
                var data = db.Colors.FirstOrDefault(x => x.ColorCode == models.ColorCode);
                if (data != null)
                {
                    data.ColorName = models.ColorName;
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

        public ActionResult ColorDel(string Id)
        {
            var data = db.Colors.FirstOrDefault(x => x.ColorCode == Id);
            if (data != null)
            {
                try
                {
                    db.Colors.Remove(data);
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