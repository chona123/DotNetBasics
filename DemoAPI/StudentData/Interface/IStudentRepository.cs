using System;
using System.Collections.Generic;
using System.Text;
using StudentData.Model;

namespace StudentData.Interface
{
   public interface IStudentRepository
    {

        IEnumerable<StudentList> GetAllStudentList();
        StudentList GetStudentList(int id);
        List<StudentList> AddStudent();
    }






}
