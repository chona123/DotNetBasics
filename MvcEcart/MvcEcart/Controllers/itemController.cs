using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcEcart.Models;
using MvcEcart.viewdataModel;
using System.IO;

namespace MvcEcart.Controllers
{
    public class itemController : Controller
    {


        
        public ActionResult Index()
        {
            ECartDBEntities objECartDBEntities = new ECartDBEntities();
            itemviewModel objitemviewModel = new itemviewModel();

            objitemviewModel.categorySelectListItem = (from Objcat in objECartDBEntities.categoryIds
                                                       select new SelectListItem
                                                       {
                                                           Text = Objcat.categoryName,
                                                           Value = Objcat.categoryId1.ToString(),
                                                           Selected = true

                                                       });



            return View(objitemviewModel);

        }
		
		


        [HttpPost]
        public JsonResult Index(itemviewModel objitemviewModel)
        {
            ECartDBEntities objECartDBEntities = new ECartDBEntities();
            string Newimage = Guid.NewGuid() + Path.GetExtension(objitemviewModel.imagePath.FileName);
            objitemviewModel.imagePath.SaveAs(Server.MapPath("~/Images/" + Newimage ));
            

            item objiitem = new item();
            objiitem.imagePath = "~/Images/" + Newimage;
            objiitem.cateogoryId = objitemviewModel.categoryId;
            objiitem.description = objitemviewModel.description;
            objiitem.itemCode = objitemviewModel.itemCode;
            objiitem.itemId = objitemviewModel.itemId;
            objiitem.itemName = objitemviewModel.itemName;
            objiitem.itemPrice = objitemviewModel.itemPrice;
            objECartDBEntities.items.Add(objiitem);
            objECartDBEntities.SaveChanges();

            return Json(new {Success=true,Message="Item added successfully."},JsonRequestBehavior.AllowGet);
        }







    }
}
