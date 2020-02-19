using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ColorRoomManager.Models;
using ColorRoomManager.ViewModels;

namespace ColorRoomManager.Controllers
{
    public class ProductColorsController : Controller
    {
        DBContext db = new DBContext();
        // GET: ProductColors
        public ActionResult Index()
        {
            var lst = db.ProductColors.ToList();

            if (lst.Count > 0)
            {
                return View(lst);
            }
            return View();            
        }

        public ActionResult ProductColorsDel(string Id)
        {
            var data = db.ProductColors.FirstOrDefault(x => x.ProductCode == Id);
            if (data != null)
            {
                try
                {
                    db.ProductColors.Remove(data);
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