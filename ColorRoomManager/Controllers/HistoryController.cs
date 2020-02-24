using ColorRoomManager.Models;
using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ColorRoomManager.Controllers
{
    public class HistoryController : Controller
    {

      private  DBContext db = new DBContext();

        // GET: History
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Mixing(int page = 1, string searchString = "")
        {
            ViewBag.Page = (page - 1) * 15;
            ViewBag.SearchString = searchString;
            IPagedList result;

            if (!String.IsNullOrEmpty(searchString))
            {
                result =db.MixRaws.Where(x=>(x.MixBacode.Contains(searchString) || x.ProductName.Contains(searchString))).OrderByDescending(x => x.CreateTime).ToPagedList(page, 15);
            }
            else
            {
                result = db.MixRaws.OrderByDescending(x => x.CreateTime).ToPagedList(page, 15);
            }
            if (result == null)
            {
                return HttpNotFound();
            }
            return View(result);
        }

        public ActionResult Crushing(int page = 1, string searchString = "")
        {
            ViewBag.Page = (page - 1) * 15;
            ViewBag.SearchString = searchString;
            IPagedList result;

            if (!String.IsNullOrEmpty(searchString))
            {
                result = db.CrushRaws.Where(x => (x.MixBacode.Contains(searchString) || x.ProductName.Contains(searchString))).OrderByDescending(x => x.CreateTime).ToPagedList(page, 15);
            }
            else
            {
                result = db.CrushRaws.OrderByDescending(x => x.CreateTime).ToPagedList(page, 15);
            }
            if (result == null)
            {
                return HttpNotFound();
            }
            return View(result);
        }
    }
}