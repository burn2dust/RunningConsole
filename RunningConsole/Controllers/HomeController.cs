using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RunningConsole.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Application Info:";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Company Info:";

            return View();
        }
    }
}