using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bogus;

namespace SchoolContext
{
    class BogusClass
    {
        public string FirstName { get; set; }
        public string lastName { get; set; }
       // public int Age { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }

        public string Address3 { get; set; }

        public string PhoneNumber { get; set; }

       



        public List<BogusClass> SetDetails()
        {
           // var fake = new SchoolContext.fakeclass<BogusClass>()
            var fakedetails = new SchoolContext.MyFaker<BogusClass>()
                   .RuleFor(c => c.FirstName, f => f.Name.FirstName())
                   .RuleFor(c => c.lastName, f => f.Name.LastName())
                   .RuleFor(c => c.Address1, f => f.Address.BuildingNumber())
                   .RuleFor(c => c.Address2, f => f.Address.City())
                   .RuleFor(c => c.Address3, f => f.Address.Country())
                   .RuleFor(c => c.PhoneNumber, f => f.Person.Phone);

            var users = fakedetails.Generate(10);
            fakedetails.Validate();
           return users;

        }

       public void Getdetails()
        {
           BogusClass objBogus = new BogusClass();
           var list  = objBogus.SetDetails();
           foreach (var Newitems in list)
           {
               Console.WriteLine("FirstName: {0}     lastName: {1}  Building No: {2}   City: {3}   Country: {4}    phone: {5}", Newitems.FirstName, Newitems.lastName, Newitems.Address1, Newitems.Address2, Newitems.Address3, Newitems.PhoneNumber);

           }
               //Filter

               var listFiltered = list.OrderBy(x => x.Address1).ToList();

           foreach(var filterList in listFiltered)
           {


               Console.WriteLine("Filtered List");
               Console.WriteLine("  Building No: {0}   ",  filterList.Address1);
           }
           

        }
      
       







    }
}

