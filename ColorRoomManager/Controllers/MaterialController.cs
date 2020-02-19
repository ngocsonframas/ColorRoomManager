using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ColorRoomManager.Models;

namespace ColorRoomManager.Controllers
{
    public class MaterialController : Controller
    {
        DBContext db = new DBContext();
        // GET: Material
        public ActionResult Index()
        {
            var lst = db.Materials.ToList();
            if (lst.Count > 0)
            {
                return View(lst);
            }
            return View();
        }

        public JsonResult MaterialAdd(Material models)
        {
            int status = 0;

            if (models != null)
            {
                var checkData = db.Materials.FirstOrDefault(x => x.MaterialCode == models.MaterialCode);
                if (checkData != null)
                {
                    status = -1;
                }

                Material material = new Material();
                material.MaterialCode = models.MaterialCode;
                material.MaterialName = models.MaterialName;
                material.IsActive = models.IsActive;
                material.CreateBy = User.Identity.Name;
                material.CreateTime = DateTime.Now;

                try
                {
                    db.Materials.Add(material);
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
        public ActionResult MaterialUp(string Id)
        {
            var data = db.Materials.FirstOrDefault(x => x.MaterialCode == Id);
            if (data != null)
            {
                return PartialView("/Views/Material/_MaterialUp.cshtml", data);
            }
            //return View("Index");
            return RedirectToAction("Index");
        }

        public JsonResult MaterialUp(Material models)
        {
            bool status = false;

            if (models != null)
            {
                var data = db.Materials.FirstOrDefault(x => x.MaterialCode == models.MaterialCode);
                if (data != null)
                {
                    data.MaterialName = models.MaterialName;
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

        public ActionResult MaterialDel(string Id)
        {
            var data = db.Materials.FirstOrDefault(x => x.MaterialCode == Id);
            if (data != null)
            {
                try
                {
                    db.Materials.Remove(data);
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