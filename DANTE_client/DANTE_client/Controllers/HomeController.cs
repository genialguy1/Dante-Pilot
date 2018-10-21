using DANTE_client.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DANTE_client.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult DefectList()
        {
            ViewBag.Title = "DANTE Pilot";
            List<Defect> lst_Defect = Utiltity.getDefectList();
            return View(lst_Defect.AsEnumerable());
        }
    }
}