using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SchoolContext
{
    class ClassRoom
    {

        private string Name;
        private int Age;
        private int Standard;

        public ClassRoom(string Name, int Age, int Standard)
        {
            this.Name = Name;
            this.Age = Age;
            this.Standard = Standard;
        }
        public ClassRoom()
        {

        }

        public string GetName { get { return Name; } }
        public int GetAge { get { return Age; } }
        public int GetStandard { get { return Standard; } }

        public List<ClassRoom> ListOfStudents = new List<ClassRoom>();
        public IEnumerable<ClassRoom> Addstudents()
        {

            ListOfStudents.Add(new ClassRoom("Vihaan", 15, 10));
            ListOfStudents.Add(new ClassRoom("Shyam", 15, 10));
            ListOfStudents.Add(new ClassRoom("Ranjith", 15, 10));
            ListOfStudents.Add(new ClassRoom("Prasad", 15, 10));
            ListOfStudents.Add(new ClassRoom("Hari", 15, 10));
            ListOfStudents.Add(new ClassRoom("Vetri", 16, 11));
            ListOfStudents.Add(new ClassRoom("Arun", 16, 11));
            ListOfStudents.Add(new ClassRoom("Udhay", 16, 11));
            ListOfStudents.Add(new ClassRoom("Roshan", 16, 11));
            ListOfStudents.Add(new ClassRoom("Ishaan", 16, 11));
            ListOfStudents.Add(new ClassRoom("Vikash", 17, 12));
            ListOfStudents.Add(new ClassRoom("Aadhvik", 17, 12));
            ListOfStudents.Add(new ClassRoom("Gugan", 17, 12));
            ListOfStudents.Add(new ClassRoom("Praveen", 17, 12));
            ListOfStudents.Add(new ClassRoom("Shree", 17, 12));

            return ListOfStudents;
        }

        public void GetArray()
        {
             ClassRoom objCls = new ClassRoom();
            var details = objCls.Addstudents();
            var list = details.ToArray();
            foreach(var items in list)
            {
                Console.WriteLine("Name: {0} Age: {1} Class: {2}",items.Name,items.Age,items.Standard );
            }
             
        }
      

    }

    interface IStudent
    {
        void GetStudent();
    }

    interface ITeacher
    {
        void AssignTeacher();
    }
    interface IRoomNumber
    {
        void GetRoom();
    }


    class StandardTen : IStudent, ITeacher, IRoomNumber
    {


        public void GetStudent()
        {

            ClassRoom objCls = new ClassRoom();
            objCls.Addstudents();

            List<ClassRoom> listFiltered = objCls.ListOfStudents.Where(items => items.GetStandard == 10).ToList();

            // Console.WriteLine("Getstudent");
            foreach (ClassRoom listItems in listFiltered)
            {
                Console.WriteLine("Name: {0} Age: {1} Standard: {2}", listItems.GetName, listItems.GetAge, listItems.GetStandard);

            }


        }
     public void AssignTeacher()
        {
            Teacher objTeacher = new Teacher("Abel", 32, "Teacher");
            Console.WriteLine("Teacher Name:", objTeacher.Name);
        }


     public void GetRoom()
     {
         Console.WriteLine("10th classRoom No: 10A");
     }







    }











}
