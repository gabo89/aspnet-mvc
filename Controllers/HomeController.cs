using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SimpleFrameworkApp.Controllers
{
    public class HomeController : Controller
    {
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
            var demotext = ConfigurationManager.AppSettings["demokeyvalue"];
            ViewBag.Message = "Your contact page."+ demotext;

            return View();
        }
    }
}