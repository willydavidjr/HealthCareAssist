using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Konzole.HealthCareAssistSystem.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            //Sample lang sinesearch ko pa yung pagtawag sa api 
            //string response = string.Empty;
            //using (var client = new WebClient())
            //{
            //    client.Headers.Add("content-type", "application/json");//
            //    response = client.DownloadString("http://localhost:2267/api/Customer/1");
            //}

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