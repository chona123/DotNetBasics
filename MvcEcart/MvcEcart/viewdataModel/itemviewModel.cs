using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Web.Mvc;

namespace MvcEcart.viewdataModel
{
    public class itemviewModel
    {
        public Guid itemId { get; set; }
        public int categoryId { get; set; }
        public string itemCode { get; set; }
        public string itemName { get; set; }
        public string description { get; set; }
        public decimal itemPrice { get; set; }
        public HttpPostedFileBase imagePath { get; set; }
       
        public IEnumerable<SelectListItem> categorySelectListItem { get; set; }
    }
}