
using GMSEPSOMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GMSEPSOMS.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult LoginIn(LoginINM login)
        {
            //    if (ModelState.IsValid)
            //    {


            //        if (login.UserName == "Admin" && login.Pwd == "Admin")
            //        {

            //            Session["GMS"] = "Y";
            //            Session["EPS"] = "Y";
            //            Session["OMS"] = "Y";
            //            Session["UserName"] = "Admin";
            //            Session["UserId"] = 102;
            //            Session["ProfileId"] = 1;
            //            //Session["ProfileCode"] = result.ProfileCode;
            //            //Session["ProfileName"] = result.ProfileName;
            //            Session["SessionId"] = Session.SessionID;
            //            Session["IpAddress"] = HttpContext.Request.UserHostAddress;


            //            //List<Menudetails_get_Result> menuresult = new List<Menudetails_get_Result>(); ;
            //            //var menudb = entity.Menudetails_get((int)Session["ProfileId"], (string)Session["GMS"], (string)Session["EPS"], (string)Session["OMS"]).ToList();
            //            //foreach (Menudetails_get_Result mrs in menudb)
            //            //{
            //            //    menuresult.Add(mrs);
            //            //}
            //            //Session["MenuMaster"] = menuresult;
            //            return RedirectToAction("Index", "Dashboard");
            //        }
            //        else
            //        {
            //            TempData["StatusMsg"] = "IncorrectName and Password";
            //        }

            //    }
            //    else
            //    {
            //        TempData["StatusMsg"] = "Please fill the details Properly.!";
            //    }

            //    return View("login");
            //}

            return RedirectToAction("Index", "Dashboard");
        }
    }
}