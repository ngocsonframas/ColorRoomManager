using ColorRoomManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ColorRoomManager.Controllers
{
    public class HistoryController : Controller
    {

        DBContext db = new DBContext();

        // GET: History
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Mixing()
        {
            var data = db.MixRaws.ToList();
            if (data.Count> 0)
            {
                return View(data);
            }
            return View();
        }

        public ActionResult Crushing()
        {
            var data = db.CrushRaws.ToList();
            if (data.Count > 0)
            {
                return View(data);
            }
            return View();
        }
    }
}