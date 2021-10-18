using System;
using System.Collections.Generic;
using System.Linq;

public class baseinherit_demo
{
    protected int basemeth(int a, int b)
    {
        return a + b;
    }
}
public class derivedinherit_demo : baseinherit_demo
{
    public int dervmeth(int a, int b)

    {

        Console.WriteLine("base method" + basemeth(a, b));
        return (a - b);


    }
}
namespace sample

{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Inheritance Demo");
            Console.WriteLine("    ");
            int Number1, Number2;
            Console.WriteLine("please enter the Number1");
            Number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("please enter the Number2");
            Number2 = Convert.ToInt32(Console.ReadLine());
            derivedinherit_demo objbase = new derivedinherit_demo();
            //int add = objbase.basemeth(Number1, Number2);

            int sub = objbase.dervmeth(Number1, Number2);
            Console.WriteLine("Sum of two Numbers:" + add.ToString());
            Console.WriteLine("diff of two Numbers:");
           

            



            arrdemo objdemo = new arrdemo();

            objdemo.printarr();
            objdemo.removearr(8);

            objdemo.printarr();
            objdemo.additem(25);
            objdemo.additem(30);
            objdemo.printarr();

            objdemo.replaceitem();
            objdemo.printarr();

            Console.WriteLine("    ");
            //Anotherway of Handling array insert
            Console.WriteLine("Anotherway of Handling array insert");
            Console.WriteLine("    ");
            newArray newobj = new newArray();
            newobj.AnotherwayOfInsert();

        }
    }
    public class arrdemo
    {
        public int[] arr = new int[] { 2, 4, 6, 8, 10 };

        

        public void removearr(int inputval)
        {
            //Array.Resize(ref arr, 4);
         
            arr = arr.Except(new int[] { inputval}).ToArray();
            

        }

        public void printarr()
        {
            foreach (var arritem in arr)
            {
                Console.WriteLine("Resized array :" + arritem);
            }
        }
         public void additem(int newitem)
        {

            arr = arr.Append(newitem).ToArray();
        }

        public void replaceitem()
        {
            arr.SetValue(45, 3);
        }



    }
}
