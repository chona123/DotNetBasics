using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ListMVC.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            ViewBag.countries = new List<string>()
            {
                "India",
                "US",
                "UK",
                "Canada",
                "France"
            };
            return View();
        }

    }
}
