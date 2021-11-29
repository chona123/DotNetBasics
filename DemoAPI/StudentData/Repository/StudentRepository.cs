using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using StudentData.Interface;
using StudentData.Model;

namespace StudentData.Repository
{
   public  class StudentRepository : IStudentRepository
    {
         static List<StudentList> studentdetails = new List<StudentList>
        {
                new StudentList() { Id = 1, Name = "Hari", Grade = "V",Gender = Gender.Male } ,
                new StudentList() { Id = 2, Name = "Ram",  Grade = "V",Gender = Gender.Male } ,
                new StudentList() { Id = 3, Name = "Vishu", Grade = "V",Gender = Gender.Male } ,
                new StudentList() { Id = 4, Name = "Manisha" , Grade = "V",Gender = Gender.Male },
                new StudentList() { Id = 5, Name = "Rahul" , Grade = "V",Gender = Gender.Male  },
                new StudentList() { Id = 6, Name = "Chris" ,  Grade = "V" ,Gender = Gender.Male } ,
                new StudentList() { Id = 7, Name = "Vidhusha" ,  Grade = "V",Gender = Gender.Male },
                new StudentList() { Id = 8, Name = "Karishma", Grade = "IV",Gender = Gender.Male } ,
                new StudentList() { Id = 9, Name = "Diana",  Grade = "IV",Gender = Gender.Male  } ,
                new StudentList() { Id = 10, Name = "Vishal", Grade = "IV" ,Gender = Gender.Male } ,
                new StudentList() { Id = 11, Name = "Abishek" , Grade = "IV",Gender = Gender.Male },
                new StudentList() { Id = 12, Name = "Vikash" , Grade = "IV",Gender = Gender.Female },
                new StudentList() { Id = 13, Name = "Vishal" ,  Grade = "IV",Gender = Gender.Female },
        };

        public IEnumerable<StudentList> GetAllStudentList()
        {
            return studentdetails;
        }

        public StudentList GetStudentList(int id)
        {
            StudentList FilterList =  studentdetails.FirstOrDefault(x =>x.Id == id);
            return FilterList;
        }



        public List<StudentList> AddStudent()
        {
            // studentdetails.Add(new StudentList() { Id = 14, Name = "Vinay", Grade = "IV" });



            List<StudentList> AccessList = studentdetails.Where(x => x.Gender == Gender.Male).ToList();
            return AccessList;
        }



       
    }
}
