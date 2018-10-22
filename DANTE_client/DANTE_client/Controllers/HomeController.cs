using DANTE_client.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace DANTE_client.Controllers
{

    public class HomeController : Controller
    {
        // GET: Home
        [Authorize]
        public ActionResult DefectList()
        {
            ViewBag.Title = "DANTE Pilot";
            List<Defect> lst_Defect = Utiltity.getDefectList();
            return View(lst_Defect.AsEnumerable());
        }

        public ActionResult login()
        {
            return View("Login");
        }

        [HttpPost]
        public ActionResult validateUser()
        {
            if (Request.Form["txt_Login_UserName"] == "admin" && Request.Form["txt_Login_Password"] == "admin")
            {
                FormsAuthentication.SetAuthCookie(Request.Form["txt_Login_UserName"], true);
                RedirectToAction("DefectList");
            }
            else
                RedirectToAction("login");

            return null;

        }
    }
}