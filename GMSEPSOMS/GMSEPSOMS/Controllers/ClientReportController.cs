﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GMSEPSOMS.Controllers
{
    public class ClientReportController : Controller
    {
        // GET: ClientReport    
        public ActionResult ClientReport()
        {
            string name = "naveen";
            return View();
        }
    }
}