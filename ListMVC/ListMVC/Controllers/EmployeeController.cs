using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using ListMVC.Models;





namespace ListMVC.Controllers
{
    public class EmployeeController : Controller
    {
        //
        // GET: /API/

        public ActionResult EmpIndex(int? id)
        {
            return View();
        }



  [HttpPost]    
        public  async Task<ActionResult> GetEmployeeIndex()
        {
            IList<Employee> EmployeeList = new List<Employee>();
            string Baseurl = "https://reqres.in";
 
            using (var client = new HttpClient())
            {
                //Passing service base url
                client.BaseAddress = new Uri(Baseurl);
               client.DefaultRequestHeaders.Clear();
                //Define request data format
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                //Sending request to find web api REST service resource GetAllEmployees using HttpClient

                HttpResponseMessage Res = await client.GetAsync("/api/users?page=2");
              
                //Checking the response is successful or not which is sent using HttpClient
                if (Res.IsSuccessStatusCode)
                {
                    var response = Res.Content.ReadAsAsync<JObject>();
                    //Storing the response details recieved from web api
                   // EmpResponse = Res.Content.ReadAsStringAsync().Result;
                    //Deserializing the response recieved from web api and storing into the Employee list

                  var data =   response.Result["data"].ToString();
                  EmployeeList = JsonConvert.DeserializeObject<List<Employee>>(data);
                   return View(EmployeeList);
                   
                }

                return RedirectToAction("Index");
               

               
            }
           
       }
 

    }


    }
       

      

