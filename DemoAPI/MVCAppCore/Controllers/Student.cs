using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVCAppCore.Models;
using System;
using System.Collections.Generic;

namespace MVCAppCore.Controllers
{
    public class StudentController : Controller, IStudent
    {
        static List<Student> studentdetails = new List<Student>
        {
                new Student() { Id = 1, Name = "Hari", Grade = "V",Gender = "Male" } ,
                new Student() { Id = 2, Name = "Ram",  Grade = "V",Gender = "Male"  } ,
                new Student() { Id = 3, Name = "Vishu", Grade = "V",Gender = "Male"  } ,
                new Student() { Id = 4, Name = "Manisha" , Grade = "V",Gender = "Female" },
                new Student() { Id = 5, Name = "Rahul" , Grade = "V",Gender = "Male"  },
                new Student() { Id = 4, Name = "Chris" ,  Grade = "V",Gender = "Male"  } ,
                new Student() { Id = 4, Name = "Vidhusha" ,  Grade = "V",Gender = "Female" },
                new Student() { Id = 1, Name = "Karishma", Grade = "V",Gender = "Female" } ,
                new Student() { Id = 2, Name = "Diana",  Grade = "V",Gender = "Female"  } ,
                new Student() { Id = 3, Name = "Vishal", Grade = "V",Gender = "Male"  } ,
                new Student() { Id = 4, Name = "Abishek" , Grade = "V",Gender = "Female"  },
                new Student() { Id = 5, Name = "Vikash" , Grade = "V",Gender = "Male"  },
                new Student() { Id = 4, Name = "Abinav" ,  Grade = "V",Gender = "Male"  },
                new Student() { Id = 4, Name = "Aadhvik" ,  Grade = "V",Gender = "Female" },
                new Student() { Id = 1, Name = "Vihaan", Grade = "V",Gender = "Male" },
                new Student() { Id = 2, Name = "Rithesh",  Grade = "V",Gender = "Male"  },
                new Student() { Id = 3, Name = "Jhosvi", Grade = "V",Gender = "Female"  },
                new Student() { Id = 4, Name = "Mirnalini" , Grade = "V",Gender = "Female"  },
                new Student() { Id = 5, Name = "Jamy" , Grade = "V",Gender = "Male"  } ,
                new Student() { Id = 4, Name = "Adams" ,  Grade = "V",Gender = "Male"  } ,
                new Student() { Id = 4, Name = "smithy" ,  Grade = "V",Gender = "Female" }
                    };




        // GET: Student
        public ActionResult Index()
        {
            return View(studentdetails);
        }

        // GET: Student/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Student/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Student/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Student/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Student/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Student/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Student/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        public void GetStudent()
        {
            throw new NotImplementedException();
        }

        public void PrintStudentlist()
        {
            throw new NotImplementedException();
        }
    }
}
