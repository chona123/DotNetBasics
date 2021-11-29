using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SchoolContext
{
    class Employee
    {



        private string _name;
        private int _age;
        private string _role;


        public string Name { get { return _name; } }
        // public int Age { get { return _age; } }

        public string Role { get { return _role; } }

        public int IsAllowedAge
        {
            set
            {
                if (_age < 20)
                {
                    throw new Exception("UnderAge Category");
                }
                this._age = value;


            }
            get
            {

                return _age;
            }


        }

        public Employee(string Name, int Age, String Role)
        {
            this._name = Name;

            this._age = IsAllowedAge;

            this._role = Role;
        }




        public virtual void Salary(int Sal)
        {
            //Console.WriteLine("Name: {0}", "Age: {1}", "Role: {2}", GetName, GetAge, GetRole); 
            Console.WriteLine("Salary Method: {0}", Sal);

        }

    }




    //class Principal : Employee
    //{
    //    public Principal(string Name, int Age, String Role)
    //        : base(Name, Age, Role)
    //    {

    //    }
    //    public override void Salary(int Sal)
    //    {
    //        Console.WriteLine("Name: {0} Age: {1} Role: {2}", GetName, GetAge, GetRole);
    //        Console.WriteLine("Principal Salary: {0}", Sal);

    //    }



    //}

    class Principal
    {
        Employee obj = new Employee("Ram", 12, "Principal");
        public void Print()
        {
            //Console.WriteLine("Name: {0} Age: {1} Role: {2}", obj.Name, obj.Age, obj.Role);

        }
    }




    class Teacher : Employee
    {

        public Teacher(string Name, int Age, String Role)
            : base(Name, Age, Role)
        {

        }
        public override void Salary(int Sal)
        {
            Console.WriteLine("Name: {0} Age: {1} Role: {2}", Name, IsAllowedAge, Role);
            Console.WriteLine("Teacher Salary: {0}", Sal);

        }


    }



    class Admin : Employee
    {
        public Admin(string Name, int Age, String Role)
            : base(Name, Age, Role)
        {

        }
        public override void Salary(int Sal)
        {
            Console.WriteLine("Name: {0} Age: {1} Role: {2}", Name, IsAllowedAge, Role);
            Console.WriteLine("Admin Salary: {0}", Sal);

        }

    }



    class Staff : Employee
    {
        public Staff(string Name, int Age, String Role)
            : base(Name, Age, Role)
        {

        }
        public override void Salary(int Sal)
        {
            // Console.WriteLine("Name: {0} Age: {1} Role: {2}", Name, Age, Role);
            Console.WriteLine("Staff Salary: {0}", Sal);

        }


    }




    class School
    {
        static void Main(string[] args)
        {

            BogusClass objbogus = new BogusClass();
           // objbogus.SetDetails();
            objbogus.Getdetails();


            //Principal objPr = new Principal("Rahul", 45, "Principal");
            //objPr.Salary(80000);
            //Console.WriteLine();
            try
            {
                Teacher objTeacher = new Teacher("Akil", 30, "Teacher");
                //objTeacher.IsAllowedAge = 15;



                objTeacher.Salary(30000);

                //Admin objAdmin = new Admin("Venu", 30, "Admin");
                //objAdmin.Salary(20000);


            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
            //Console.WriteLine();


            //Console.WriteLine();

            //Staff objStaff = new Staff("Gopal", 32, "Staff");
            //objStaff.Salary(15000);
            //Console.WriteLine();

            StandardTen objTen = new StandardTen();
            objTen.GetStudent();








            Console.ReadKey();




        }
    }







}
