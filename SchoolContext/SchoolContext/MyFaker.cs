using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using Bogus;

namespace SchoolContext
{


    public interface IBogus
    {

         string FirstName { get; set; }
         string LastName { get; set; }
    }


    public class MyFaker<T> : Faker<T> where T : class,IBogus
    {
        public string FullName { get; set; }
        public override bool Validate(string ruleSets = null)
       {
            

           return true;

       }

        public override List<T> Generate(int count, string ruleSets = null) 
        {
            
            var list = base.Generate(count, ruleSets);
            var listtoreturn = new List<T>();

            foreach (var item in list)
            {
                //var temp = (BogusClass)Convert.ChangeType(item, typeof(BogusClass));
                //temp.FirstName = $"{temp.FirstName}_{temp.lastName}";
                //listtoreturn.Add((T)Convert.ChangeType(temp, typeof(T)));


                var temp = item.GetType();
                var TypeProperties = this.binder.GetMembers(typeof(T));
                var data = (temp.)






            }

            return listtoreturn;
        }


        //public List<T> NewList()
        //{
        //    var list = base.Generate();
        //    var listtoreturn = new List<T>();
        //   var TypeProperties = this.binder.GetMembers(typeof(T));
        //    return listtoreturn;


        //}







}
}
