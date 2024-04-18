using Microsoft.Extensions.Logging;
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

        private readonly ILogger<HomeController> _logger;

        public HomeController()
        { }
        
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }


        public ActionResult Index()
        {
            _logger.LogInformation("Página de inicio visitada.");
            return View();
        }

        public ActionResult About()
        {
            _logger.LogInformation("Página de about visitada.");
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            _logger.LogInformation("Página de contact visitada.");
            var demotext = ConfigurationManager.AppSettings["demokeyvalue"];
            ViewBag.Message = "Your contact page."+ demotext;

            return View();
        }
    }
}