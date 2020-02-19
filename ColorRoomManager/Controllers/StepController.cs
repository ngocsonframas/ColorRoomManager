using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ColorRoomManager.Models;

namespace ColorRoomManager.Controllers
{
    public class StepController : Controller
    {
        DBContext db = new DBContext();
        // GET: Step
        public ActionResult Index()
        {
            var lst = db.Steps.ToList();
            if (lst.Count > 0)
            {
                return View(lst);
            }
            return View();
        }

        public JsonResult StepAdd(Step models)
        {
            int status = 0;

            if (models != null)
            {
                var checkData = db.Steps.FirstOrDefault(x => x.StepCode == models.StepCode);
                if (checkData != null)
                {
                    status = -1;
                }

                Step step = new Step();
                step.StepCode = models.StepCode;
                step.StepName = models.StepName;
                step.IsActive = models.IsActive;
                step.CreateBy = User.Identity.Name;
                step.CreateTime = DateTime.Now;

                try
                {
                    db.Steps.Add(step);
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
        public ActionResult StepUp(string Id)
        {
            var data = db.Steps.FirstOrDefault(x => x.StepCode == Id);
            if (data != null)
            {
                return PartialView("/Views/Step/_StepUp.cshtml", data);
            }
            return View("Index");
            //return RedirectToAction("Index");
        }

        public JsonResult StepUp(Step models)
        {
            bool status = false;
            if (models != null)
            {
                var data = db.Steps.FirstOrDefault(x => x.StepCode == models.StepCode);
                if (data != null)
                {
                    data.StepName = models.StepName;
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

        public ActionResult StepDel(string Id)
        {
            var data = db.Steps.FirstOrDefault(x => x.StepCode == Id);
            if (data != null)
            {
                try
                {
                    db.Steps.Remove(data);
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