using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ListMVC.Models;

namespace ListMVC.Controllers
{
    public class studentController : Controller
    {
      static  List<Student> studentdetails = new List<Student>{ 
                new Student() { studentid = 1, name = "Hari", Age = 10, grade = "V" } ,
                new Student() { studentid = 2, name = "Ram",  Age = 10, grade = "V" } ,
                new Student() { studentid = 3, name = "Vishu",  Age = 10, grade = "V" } ,
                new Student() { studentid = 4, name = "Manisha" , Age = 10, grade = "V" } ,
                new Student() { studentid = 5, name = "Rahul" , Age = 10, grade = "V" } ,
                new Student() { studentid = 4, name = "Chris" , Age = 10, grade = "V" } ,
                new Student() { studentid = 4, name = "Vidhush" , Age = 10, grade = "V" } 
            };

        public ActionResult details()
        {
         
          return View(studentdetails);
        }

        public ActionResult detailsview1(int Id)
        {
            //fetch students from the DB using Entity Framework here
            var std = studentdetails.Where(s => s.studentid == Id).FirstOrDefault();

            return View(std);
        }

        public ActionResult Edit(int Id)
        {
            //here, get the student from the database in the real application

            //getting a student from collection for demo purpose
            var std = studentdetails.Where(s => s.studentid == Id).FirstOrDefault();

            return View(std);
        }
        [HttpPost]
        public ActionResult Edit(Student std)
        {
            //update student in DB using EntityFramework in real-life application

            //update list by removing old student and adding updated student for demo purpose
            var student = studentdetails.Where(s => s.studentid == std.studentid).FirstOrDefault();
            studentdetails.Remove(student);
            studentdetails.Add(std);

            return RedirectToAction("details");
        }
        public ActionResult delete(int Id)
        {
            //here, get the student from the database in the real application

            //getting a student from collection for demo purpose
            var std = studentdetails.Where(s => s.studentid == Id).FirstOrDefault();

            return View(std);
        }
        [HttpPost]
        public ActionResult delete(Student std)
        {
            //update student in DB using EntityFramework in real-life application

            //update list by removing old student and adding updated student for demo purpose
            var student = studentdetails.Where(s => s.studentid == std.studentid).FirstOrDefault();
            studentdetails.Remove(student);
             //studentdetails.GetEnumerator();

            return RedirectToAction("details");
        }

       







    }
}
