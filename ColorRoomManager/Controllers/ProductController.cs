using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ColorRoomManager.Models;
using ColorRoomManager.ViewModels;
namespace ColorRoomManager.Controllers
{
    public class ProductController : Controller
    {
        DBContext db = new DBContext();
        // GET: Product
        public ActionResult Index()
        {
            var lst = db.Products.ToList();

            if (lst.Count > 0)
            {
                return View(lst);
            }

            return View();
        }

        public ActionResult ProductViewModels()
        {
            var lstColors = db.Colors.ToList();
            ProductViewModels vmDemo = new ProductViewModels();
            return View(vmDemo);
        }

        public JsonResult ProductAdd(Product models)
        {
            int status = 0;

            if (models != null)
            {
                var checkData = db.Products.FirstOrDefault(x => x.ProductCode == models.ProductCode);
                if (checkData != null)
                {
                    status = -1;
                }

                Product product = new Product();
                product.ProductCode = models.ProductCode;
                product.ProductName = models.ProductName;
                product.IsActive = models.IsActive;
                product.CreateBy = User.Identity.Name;
                product.CreateTime = DateTime.Now;

                try
                {
                    db.Products.Add(product);
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
        public ActionResult ProductUp(string Id)
        {
            var data = db.Products.FirstOrDefault(x => x.ProductCode == Id);
            if (data != null)
            {
                return PartialView("/Views/Product/_ProductUp.cshtml", data);
            }
            return View("Index");
        }

        [HttpGet]
        public ActionResult ProductAddColor(string Id)
        {
            var checkData = db.ProductColors.Where(x => x.ProductCode == Id && x.IsActive == true).ToList();

            if (checkData.Count > 0)
            {
                ViewBag.CheckData = checkData;
            }
            TempData["ProductCode"] = Id;
            var data = db.Colors.ToList();
            if (data != null)
            {
                return PartialView("/Views/Product/_ProductAddColor.cshtml", data);
            }
            return View("Index");
        }

        public JsonResult ProductUpColor(object arrayId, string PId)
        {
            bool status = false;
            var checkData = db.ProductColors.Where(x => x.ProductCode == PId && x.IsActive == true).ToList();
            foreach (var item in checkData)
            {
                db.ProductColors.Remove(item);
                db.SaveChanges();
            }
            ProductColor objColor;
            string[] res = arrayId as string[];
            if (res != null)
            {
                foreach (var item in res)
                {
                    objColor = new ProductColor();
                    objColor.ProductCode = PId;
                    objColor.ColorCode = item;
                    objColor.IsActive = true;
                    objColor.CreateBy = User.Identity.Name;
                    objColor.CreateTime = DateTime.Now;
                    db.ProductColors.Add(objColor);
                }
            }
            try
            {
                db.SaveChanges();
                status = true;
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
            return Json(status, JsonRequestBehavior.AllowGet);
        } 
        [HttpGet]
        public ActionResult ProductGetColor(string Id)
        {
            var data = db.Products.FirstOrDefault(x => x.ProductCode == Id);
            if (data != null)
            {
                return PartialView("/Views/Product/_ProductAddColor.cshtml", data);
            }
            return View("Index");
        }

        public JsonResult ProductUp(Product models)
        {
            bool status = false;
            if (models != null)
            {
                var data = db.Products.FirstOrDefault(x => x.ProductCode == models.ProductCode);
                if (data != null)
                {
                    data.ProductName = models.ProductName;
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

        public ActionResult ProductDel(string Id)
        {
            var data = db.Products.FirstOrDefault(x => x.ProductCode == Id);
            if (data != null)
            {
                try
                {
                    db.Products.Remove(data);
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