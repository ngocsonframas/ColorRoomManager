using ColorRoomManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ColorRoomManager.Controllers
{
    public class MixingOutController : Controller
    {

        private DBContext db = new DBContext();

        // GET: MixingOut
        public ActionResult Index()
        {
            var ltsMixRaw = db.MixRaws.ToList();
            ViewBag.MixRaw = ltsMixRaw;
            return View();
        }

        public JsonResult MixingOutAdd(MixingOut models)
        {
            bool status = false;
            if (models != null)
            {
                MixingOut mixingOut = new MixingOut
                {
                    MixRawId            = models.MixRawId,

                    WeightRunner       = models.WeightRunner,
                    WeightDefect       = models.WeightDefect,
                    WeightBlackDot     = models.WeightBlackDot,
                    WeighContamination = models.WeighContamination,
                    WeightRecycle      = models.WeightRecycle,
                    WeightCookie       = models.WeightCookie,
                    CreateBy           = User.Identity.Name,
                    CreateTime         = DateTime.Now,
                };
                try
                {
                    db.MixingOuts.Add(mixingOut);
                    db.SaveChanges();
                    status = true;
                }
                catch (Exception ex)
                {
                    ex.ToString();
                }
            }


            return Json(status, JsonRequestBehavior.AllowGet);
        }
    }
}