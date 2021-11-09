using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;





namespace Polymorphism_sample
{
   class Shape {
      protected int width, height;
      
      public Shape( int a = 0, int b = 0) {
         width = a;
         height = b;
      }
      public virtual int area() {
         Console.WriteLine("Parent class area :");
         return 0;
      }
   }
   class Rectangle: Shape {
      public Rectangle( int a = 0, int b = 0): base(a, b) {

      }
      public override int area () {
         Console.WriteLine("Rectangle class area :");
         return (width * height); 
      }
   }
   class Triangle: Shape {
      public Triangle(int a = 0, int b = 0): base(a, b) {
      }
      public override int area() {
         Console.WriteLine("Triangle class area :");
         return (width * height / 2); 
      }
   }
   class program {
      public void CallArea(Shape sh) {
         int a;
         a = sh.area();
         Console.WriteLine("Area: {0}", a);
      }
   }

   class Test
   {
       static void Main(string[] args)
       {
           program objprogram = new program();
           Rectangle rect = new Rectangle(10, 7);
           Triangle tri = new Triangle(10, 5);

           objprogram.CallArea(rect);
           objprogram.CallArea(tri);
           Console.ReadKey();
       }
   }
}