using ColorRoomManager.Models;
using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ColorRoomManager.Controllers
{
    public class CrushingController : Controller
    {
        DBContext db = new DBContext();
        // GET: Mixing
        public ActionResult Index()
        {
            var ltsOperator = db.Operators.Where(x => x.IsActive == true).ToList();
            var ltsProduct  = db.Products.Where(x => x.IsActive == true).ToList();
            var ltsColor    = db.Colors.Where(x => x.IsActive == true).ToList();
            var ltsStep     = db.Steps.Where(x => x.IsActive == true).ToList();
            var ltsMachine  = db.Machines.Where(x => x.IsActive == true).ToList();
            var ltsMaterial = db.Materials.Where(x => x.IsActive == true).ToList();
            var ltsLossType = db.LossTypes.Where(x => x.IsActive == true).ToList();

            ViewBag.ListOperator = ltsOperator;
            ViewBag.ListProduct  = ltsProduct;
            ViewBag.ListColor    = ltsColor;
            ViewBag.ListStep     = ltsStep;
            ViewBag.ListMachine  = ltsMachine;
            ViewBag.ListMaterial = ltsMaterial;
            ViewBag.ListLossType = ltsLossType;
            return View();
        }

        [HttpPost]
        public JsonResult CrushingAdd()
        {
            bool status = false;
            return Json(status, JsonRequestBehavior.AllowGet);
        }

        public JsonResult ColorCodeByProduct(string prodCode)
        {
            var lstCode = db.Colors.Where(x => x.ProductCode == prodCode).ToList();
            return Json(lstCode, JsonRequestBehavior.AllowGet);
        }
    }
}