﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Klinspot.Controllers
{
    public class ServicesController : BaseController
    {
        // GET: Services
        public ActionResult Index()
        {
            return View();
        }
    }
}