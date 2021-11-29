using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using StudentData.Repository;
using StudentData.Model;
using StudentData.Interface;
using System.Linq;
using System.Threading.Tasks;
using System.IO;

namespace WebAPICore.Controllers
{
   [Route("api/[controller]")]
  
    [ApiController]
    public class StudentListController : Controller
    {


        private readonly IStudentRepository _studentRepository ;
        public StudentListController(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        [HttpGet("get/{id}")]

        public IActionResult GetStudentList(int id)
        {
            try
            {
                if(id == 0)
                {
                    return NotFound();
                }
                
                return Ok(_studentRepository.GetAllStudentList());

            }
            catch
            {
                throw new Exception(); 
            }

            
     
        }
        [Route("api/{controller}/{action}")]
        public ActionResult FilterList()
        {
            
          var NewList =   _studentRepository.GetAllStudentList();
            var Temp = NewList.Where(x => x.Grade == "IV");

            return this.Ok(Temp);

        }

        [Route("about")]
        public ContentResult About()
        {
            return Content("An API listing authors of docs.asp.net.");
        }







        [Route("add")]
        [HttpPost]
        public ActionResult Add([FromBody] StudentList student)
        {
          

            return this.Ok(_studentRepository.AddStudent());
        }


        [Route("access")]
        public ActionResult Access()
        {
           return this.Ok(_studentRepository.AddStudent());
        }




       
       





    }






    }








       
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                               





