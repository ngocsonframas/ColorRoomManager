using ColorRoomManager.Models;
using ColorRoomManager.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ColorRoomManager.Controllers
{
    public class MachineController : Controller
    {
        DBContext db = new DBContext();
        // GET: Colors
        public ActionResult Index()
        {
            var lst = db.Machines.ToList();
            if (lst.Count > 0)
            {
                return View(lst);
            }
            return View();
        }

        public JsonResult MachineAdd(Machine models)
        {
            int status = 0;

            if (models != null)
            {
                var checkData = db.Machines.FirstOrDefault(x => x.Id == models.Id);
                if (checkData != null)
                {
                    status = -1;
                }
                Machine machine      = new Machine();
                machine.MachineName  = models.MachineName;
                machine.IsActive   = models.IsActive;
                machine.CreateBy   = User.Identity.Name;
                machine.CreateTime = DateTime.Now;

                try
                {
                    db.Machines.Add(machine);
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
        public ActionResult MachineUp(int? Id)
        {
            var data = db.Machines.FirstOrDefault(x => x.Id == Id);
            if (data != null)
            {
                return PartialView("/Views/Machine/_MachineUp.cshtml", data);
            }
            return View("Index");
        }

        [HttpPost]
        public JsonResult MachineUp(MachineViewModels models)
        {
            bool status = false;

            if (models != null)
            {
                var data = db.Machines.FirstOrDefault(x => x.Id == models.Id);
                if (data != null)
                {
                    data.MachineName = models.MachineName;
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

        [HttpGet]
        public ActionResult MachineDel(int? Id)
        {
            var data = db.Machines.FirstOrDefault(x => x.Id == Id);
            if (data != null)
            {
                try
                {
                    db.Machines.Remove(data);
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