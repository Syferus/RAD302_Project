using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjRAD302.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }

        // GET:
        [HttpGet]
        public PartialViewResult Add()
        {
            return PartialView("Reg");
        }

        // GET:
        [HttpGet]
        public ActionResult SpotifyDetails()
        {
            ViewBag.Title = "Spotify Details";

            return View();
        }
    }
}
