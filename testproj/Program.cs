using System;
using System.Collections.Generic;



   
   public class Listsample
    {


        List<string> authors = new List<string>(10);


        public void print()
        {

            Console.WriteLine("printinglist size " + authors.Count);
            foreach (var listitem in authors)
            {
                Console.WriteLine("stringlist : " + listitem);
            }

        }
        public void add(string strinput)
        {
            authors.Add(strinput);
        }
        public void delete(string removeitem)
        {
            authors.Remove(removeitem);

        }
        public void insert(int ind, string item)
        {
            authors.Insert(ind, item);

        }






    }

  public  class employeedemo
    {

        List<employeedemo> employeelist = new List<employeedemo>(5);

        public int emp_id;
        public string emp_name;
        public int emp_salary;

        public void printemployee()
        {
            Console.WriteLine("printinglist size " + employeelist.Count);


            foreach (var empitem in employeelist)
            {
                Console.WriteLine("emp_id : " + empitem.emp_id);
                Console.WriteLine("emp_name : " + empitem.emp_name);
                Console.WriteLine("emp_salary : " + empitem.emp_salary);

            }
            Console.WriteLine("");
        }


        public void addemployee(employeedemo inputemployee)
        {
            employeelist.Add(inputemployee);
        }
        public void insertemp(int ind, employeedemo inputemployee)
        {
            employeelist.Insert(ind, inputemployee);
        }
        public void removeemployee(employeedemo inputemployee)
        {
            employeelist.Remove(inputemployee);
        }



    }





