using ColorRoomManager.Extentions;
using ColorRoomManager.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ColorRoomManager.Controllers
{
    public class ReportController : Controller
    {
        //important Variabal for using get and post data from database
        private DBContext db = new DBContext();
        // GET: Report
        public ActionResult Index(string strQr)
        {
            rptCrushing rpt = new rptCrushing();
            DataTable dt = DataOperation.getDataTable(GlobalVariable.DBContext, strQr);
            rpt.DataSource = dt;
            rpt.DataMember = "dt";
            // CheckCookie and ChangeLanguage always have in action (it pass data to View)
            return View(rpt);
        }
    }
}