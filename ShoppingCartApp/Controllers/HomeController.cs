using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ShoppingCartApp.ServiceReference1;

namespace ShoppingCartApp.Controllers
{
    public class HomeController : Controller
    {
        Service1Client wcf = new Service1Client(); // WCF connection

        public ActionResult Index()
        {
            List<Product> topProducts = wcf.GetTopProducts().ToList(); //Uses the method from the WCF Service
            return View("Index", topProducts);
        }

        public ActionResult Dvd()
        {
            List<Product> displayDvd = wcf.GetDvds().ToList(); //Uses the method from the WCF Service
            return View("Dvd", displayDvd);
        }

        public ActionResult Games()
        {
            List<Product> displayGames = wcf.GetGames().ToList(); //Uses the method from the WCF Service
            return View("Games", displayGames);
        }

        public ActionResult Console()
        {
            List<Product> displayConsoles = wcf.GetConsoles().ToList(); //Uses the method from the WCF Service
            return View("Console", displayConsoles);
        }

        public ActionResult Components()
        {
            List<Product> displayComponents = wcf.GetComponents().ToList(); //Uses the method from the WCF Service
            return View("Components", displayComponents);
        }

        public ActionResult Handbooks()
        {
            List<Product> displayHandbooks = wcf.GetHandbooks().ToList(); //Uses the method from the WCF Service
            return View("Handbooks", displayHandbooks);
        }

        public ActionResult Pc()
        {
            List<Product> displayPcParts = wcf.GetPcParts().ToList(); //Uses the method from the WCF Service
            return View("Pc", displayPcParts);
        }
        

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View("About");
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}