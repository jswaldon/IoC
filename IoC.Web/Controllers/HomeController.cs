﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IoC.Web.Interfaces;

namespace IoC.Web.Controllers
{
    public class HomeController : Controller, IHomeController
    {
        public ILogger _logger;
        public HomeController(ILogger logger)
        {
            _logger = logger;
            _logger.Log("Test Injection");
        }
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}