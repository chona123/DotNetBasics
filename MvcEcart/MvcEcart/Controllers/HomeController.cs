using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcEcart.Models;
using MvcEcart.viewdataModel;

namespace MvcEcart.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            ECartDBEntities objECartDBEntities = new ECartDBEntities();
            CategoryviewModel objcatviewModel = new CategoryviewModel();

            objcatviewModel.categorySelectListItem = (from Objcat in objECartDBEntities.categoryIds
                                                       select new SelectListItem
                                                       {
                                                           Text = Objcat.categoryName,
                                                           Value = Objcat.categoryId1.ToString(),
                                                           Selected = true

                                                       });



            return View(objcatviewModel);

           
        }

        public ActionResult Contact()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult service()
        {
            return View();
        }

    }
}
