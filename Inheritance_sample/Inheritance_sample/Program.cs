﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Inheritance_sample
{

    class Rectangle
    {

        //member variables
        protected double length;
        protected double width;

        public Rectangle(double l, double w)
        {
            length = l;
            width = w;
        }
        public double GetArea()
        {
            return length * width;
        }
        public void Display()
        {
            Console.WriteLine("Length: {0}", length);
            Console.WriteLine("Width: {0}", width);
            Console.WriteLine("Area: {0}", GetArea());
        }
    }
    class Rect_cost : Rectangle
    {
        // private double cost;
        public Rect_cost(double l, double w) : base(l, w) { }

        public double GetCost()
        {
            double cost;
            cost = GetArea() * 50;
            return cost;
        }
        public void Cost_Display()
        {
            base.Display();
            Console.WriteLine("Cost: {0}", GetCost());
        }
    }
    class ExecuteRectangle
    {
        static void Main(string[] args)
        {
            Rect_cost objRect = new Rect_cost(3, 5.5);
            objRect.Cost_Display();
            Console.ReadLine();
        }
    }
}

