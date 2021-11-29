using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using StudentData.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPICore.Controllers
{

    [Route("api/[controller]")]

    [ApiController]
    public class DownloadController : Controller
    {


        private readonly IStudentRepository _studentRepository;
        public DownloadController(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }


        //private readonly string _filePath;


        [HttpGet("DownloadMission/{id}")]
        public IActionResult DownloadMission(int id)
        {
           // Mission toDownload = new Mission { Id = 1, name = "test" };
            string JsonString = JsonConvert.SerializeObject(_studentRepository.GetAllStudentList());
            var fileName = "test.txt";
            var mimeType = "text/plain";
            var fileBytes = Encoding.ASCII.GetBytes(JsonString);
            return new FileContentResult(fileBytes, mimeType)
            {
                FileDownloadName = fileName
             };
           // return Ok(_studentRepository.GetAllStudentList());
          


        }






    }
}
