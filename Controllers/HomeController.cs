using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace GitHubSearcher.Controllers
{
    public class HomeController : Controller
    {
        //In Web API, a controller is an object that handles HTTP requests.
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }
    }
}
