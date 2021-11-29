using CoreMVCApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CoreMVCApp.Controllers
{
    public class HomeController : Controller
    {
        //private readonly ILogger<HomeController> _logger;
        private readonly IConfiguration _Configure;
        public HomeController(IConfiguration configuration)
        {
            //_logger = logger;
            _Configure = configuration;


        }



        [HttpGet]
        public ActionResult Profile()
        {
            UserInformation user = JsonConvert.DeserializeObject<UserInformation>(Convert.ToString(TempData["Profile"]));
            return View(user);
        }


        [HttpGet]
        public ActionResult Index()
        {
            UserInformation user = new UserInformation();
            return View(user);
        }

        [HttpPost]
        public async Task<IActionResult> GetResponse(UserInformation user)
        {
            using (HttpClient client = new HttpClient())
            {
                var apiBaseUrl = _Configure.GetValue<string>("WebAPIBaseUrl");
                StringContent content = new StringContent(JsonConvert.SerializeObject(user), Encoding.UTF8, "application/json");
                string endpoint = apiBaseUrl;

                using (var Response = await client.PostAsync(endpoint, content))
                {
                    if (Response.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        TempData["Profile"] = JsonConvert.SerializeObject(user);

                        return RedirectToAction("Profile");

                    }
                    else
                    {
                        ModelState.Clear();
                        // ModelState.AddModelError(string.Empty, "Username or Password is Incorrect");
                        return View();

                    }

                }
            }




        }
    }
}