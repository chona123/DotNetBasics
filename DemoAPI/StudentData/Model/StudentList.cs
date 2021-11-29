using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace StudentData.Model
{
  public  class StudentList
    {
        public int Id { get; set; }


        //Only alphabets,space,.
        [Required]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Use letters only please")]
        public string Name { get; set; }

        public string Grade { get; set; }

        //Change to Enum
       
        public Gender Gender { get; set; }




    }
    public enum Gender
    {
        Male,
        Female
    }

}
