using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebGrease;
using log4net;
using LogManager = log4net.LogManager;

namespace SimpleFrameworkApp.Controllers
{
    public class HomeController : Controller
    {
        private static readonly ILog _log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);


        public ActionResult Index()
        {
            _log.Info("Página de inicio visitada.");
            return View();
        }

        public ActionResult About()
        {
            _log.Info("Página de about visitada.");
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            _log.Info("Página de contact visitada.");
            var demotext = ConfigurationManager.AppSettings["demokeyvalue"];
            ViewBag.Message = "Your contact page."+ demotext;

            return View();
        }
    }
}