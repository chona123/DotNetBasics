using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoreMVCApp.Models
{
    public class UserInformation
    {
         [Required]
            public string Username { get; set; }
            [Required]
            public string Grade { get; set; }
            public string Gender { get; set; }

            public string Summary { get; set; }



    }
}
