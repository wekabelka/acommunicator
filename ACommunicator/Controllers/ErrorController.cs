﻿using System.Web.Mvc;

namespace ACommunicator.Controllers
{
    public class ErrorController : Controller
    {
        [HttpGet]
        public ActionResult NotFound()
        {
            return View();
        }

        [HttpGet]
        public ActionResult SomethingWentWrong()
        {
            return View();
        }
    }
}