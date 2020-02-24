using ColorRoomManager.Models;
using ColorRoomManager.Reports.Object;
using ColorRoomManager.ViewModels;
using System;
using System.Linq;
using System.Web.Mvc;

namespace ColorRoomManager.Controllers
{
    public class MixingController : Controller
    {
        private DBContext db = new DBContext();
        private ScannerInfo _ScannerInfo;

        // GET: Mixing
        public ActionResult Index()
        {
            var ltsOperator = db.Operators.Where(x => x.IsActive == true).ToList();
            var ltsProduct = db.Products.Where(x => x.IsActive == true).ToList();
            var ltsColor = db.Colors.Where(x => x.IsActive == true).ToList();
            var ltsStep = db.Steps.Where(x => x.IsActive == true).ToList();
            var ltsMachine = db.Machines.Where(x => x.IsActive == true).ToList();
            var ltsMaterial = db.Materials.Where(x => x.IsActive == true).ToList();

            ViewBag.ListOperator = ltsOperator;
            ViewBag.ListProduct = ltsProduct;
            ViewBag.ListColor = ltsColor;
            ViewBag.ListStep = ltsStep;
            ViewBag.ListMachine = ltsMachine;
            ViewBag.ListMaterial = ltsMaterial;

            foreach (string key in HttpContext.Request.Form.AllKeys)
            {
                string value = HttpContext.Request.Form.Get(key);
                ViewBag.Weight = value;
            }

            return View();
        }

        public JsonResult MixingAdd(MixRawViewModels models)
        {
            bool status = false;
            if (models != null)
            {
                string guidResult = Guid.NewGuid().ToString().ToUpper().Substring(1, 5);
                guidResult = guidResult.Replace("-", string.Empty);
                string barCode = ("MI" + DateTime.Today.Year + DateTime.Today.Month + DateTime.Today.Day+DateTime.Today.Minute + guidResult + models.ProductCode).ToString();
                MixRaw mixRaw = new MixRaw
                {
                    ShiftName = models.ShiftName.Trim(),
                    OperatorName = models.OperatorName.Trim(),
                    ProductName = models.ProductName.Trim(),
                    MachineName = models.MachineName,
                    ColorName = models.ColorName.Trim(),
                    MaterialName = models.MaterialName.Trim(),
                    StepName = models.StepName.Trim(),
                    WeightMaterial = models.WeightMaterial,
                    WeightRecycle = models.WeightRecycle,
                    MixBacode = barCode,
                    TotalMaterial = models.TotalMaterial,
                    CreateBy = User.Identity.Name,
                    CreateTime = DateTime.Now,
                };
                try
                {
                    db.MixRaws.Add(mixRaw);
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

        //public JsonResult ColorNameByCode(string colorCode)
        //{
        //    var codeName = db.Colors
        //        .Select(x => new ColorViewModels
        //        {
        //            ColorName = x.ColorName,
        //            ColorCode = x.ColorCode,
        //        })
        //        .Where(x=>x.ColorCode ==colorCode)
        //        .FirstOrDefault();
        //    return Json(codeName,JsonRequestBehavior.AllowGet);
        //}

        public JsonResult ColorCodeByProduct(string prodCode)
        {
            var lstCode = db.Colors.Where(x => x.ProductCode == prodCode).ToList();
            return Json(lstCode, JsonRequestBehavior.AllowGet);
        }

        public ActionResult PrintMix()
        {
            var ListItem = db.MixRaws.Where(x => x.MixRawId == 8)
                .Select(x => new LabelTemplate
                {
                    ColorName = x.ColorName,
                    MaterialName = x.MaterialName,
                    ScaleWeight = x.WeightMix,
                    LabelName = "MIXING (TRỘN)",
                    Barcode = x.MixBacode
                }).ToList();

            _ScannerInfo = new ScannerInfo();
            var MyReader = new System.Configuration.AppSettingsReader();
            string print = string.Empty;
            print = MyReader.GetValue("Printer_White", typeof(string)).ToString();
            //rptMixing rpt = new rptMixing();
            //rpt.CreateDocument(false);
            //rpt.Load(ListItem);
            //rpt.PrinterName = print;
            //rpt.Dispose();
            return View();
        }
    }
}