using ColorRoomManager.Models;
using ColorRoomManager.ViewModels;
using SerialPortListener.Serial;
using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading;
using System.Timers;
using System.Web;
using System.Web.Mvc;

namespace ColorRoomManager.Controllers
{
    public class MixingController : Controller
    {
        DBContext db = new DBContext();
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

            SerialPort serialPort = new SerialPort("COM1");
            string strData = string.Empty;
            string _Weight = string.Empty;

            if (serialPort.IsOpen == false)
            {
                serialPort.Open();
                strData = serialPort.ReadExisting();
                _Weight = _Weight + strData;
            }
            ViewBag.Weight = _Weight.Trim();
            serialPort.Close();
            return View();
        }

        public JsonResult MixingAdd(MixRawViewModels models)
        {
            bool status = false;
            if (models != null)
            {
                string guidResult = Guid.NewGuid().ToString().ToUpper().Substring(1,5);
                guidResult = guidResult.Replace("-", string.Empty);
                string barCode = ("MI" +DateTime.Today.Year+ DateTime.Today.Month + DateTime.Today.Day + guidResult + models.ProductCode).ToString();
                MixRaw mixRaw = new MixRaw
                {
                    ShiftName      = models.ShiftName.Trim(),
                    OperatorName   = models.OperatorName.Trim(),
                    ProductName    = models.ProductName.Trim(),
                    MachineName    = models.MachineName,
                    ColorName      = models.ColorName.Trim(),
                    MaterialName   = models.MaterialName.Trim(),
                    StepName       = models.StepName.Trim(),
                    WeightMaterial = models.WeightMaterial,
                    WeightRecycle  = models.WeightRecycle,
                    MixBacode      = barCode,
                    TotalMaterial  = models.TotalMaterial,
                    CreateBy       = User.Identity.Name,
                    CreateTime     = DateTime.Now,
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

        public JsonResult Scales()
        {
            SerialPort serialPort = new SerialPort("COM1");
            string strData = string.Empty;
            string _Weight = string.Empty;

            if (!serialPort.IsOpen)
            {
                serialPort.Open();
                strData = serialPort.ReadExisting();
                _Weight = _Weight + strData;
                _Weight = _Weight.Trim();
            }

            serialPort.Close();
            return Json(_Weight, JsonRequestBehavior.AllowGet);
        }
    }
}