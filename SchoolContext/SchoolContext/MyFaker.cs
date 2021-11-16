using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using Bogus;

namespace SchoolContext
{



    public class MyFaker<T> : Faker<T> where T : class
    {

       public override bool Validate(string ruleSets = null)
       {
           return true;

       }



    }
}
