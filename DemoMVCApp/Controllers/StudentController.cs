using DemoMVCApp.Models;
using DemoMVCApp.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoMVCApp.Controllers
{
    public class StudentController : Controller
    {
        List<Student> StudentDetails = new List<Student>{
                new Student() { Id = 1, StudentName = "Hari", Grade = "V" } ,
                new Student() { Id = 2, StudentName = "Ram",  Grade = "V" } ,
                new Student() { Id = 3, StudentName = "Vishu",Grade = "V" },
                 new Student() { Id = 4, StudentName = "Gopi", Grade = "V" } ,
                new Student() { Id = 5, StudentName = "Rahul",  Grade = "V" } ,
                new Student() { Id = 6, StudentName = "Vidhush",Grade = "V" }
                };
        Teacher TeacherDetails = new Teacher()
        {
            EmpId = new Guid(),
            Name = "Shahul"
        };

        // GET: Student
        public ActionResult Index()
        {
           
          DataViewModel DataModel = new DataViewModel
            {
                Students = StudentDetails,
                Teacher = TeacherDetails
            };

            return View(DataModel);
        }

        public ActionResult Edit(int Id)
        {
            //here, get the student from the database in the real application

            //getting a student from collection for demo purpose
            var FilterId = StudentDetails.Where(s => s.Id == Id).FirstOrDefault();

            return Content("selected Name:"+ FilterId.StudentName);
        }


        public ActionResult delete(int Id)
        {
            //here, get the student from the database in the real application

            //getting a student from collection for demo purpose
            var DeleteItem = StudentDetails.Where(s => s.Id == Id).FirstOrDefault();

            return View(DeleteItem);
        }


        [HttpPost]
        public ActionResult delete(Student std)
        {
            //update student in DB using EntityFramework in real-life application

            //update list by removing old student and adding updated student for demo purpose
            var student = StudentDetails.Where(s => s.Id == std.Id).FirstOrDefault();
            StudentDetails.Remove(student);
            //studentdetails.GetEnumerator();

            return RedirectToAction("Index");
        }
















    }
}