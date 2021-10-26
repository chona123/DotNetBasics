using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Web.Mvc;

namespace MvcEcart.viewdataModel
{
    public class CategoryviewModel
    {
        public int categoryId { get; set; }
        public string categoryCode{get; set;}
        public string categoryName { get; set; }
        public IEnumerable<SelectListItem> categorySelectListItem { get; set; }
    }
}