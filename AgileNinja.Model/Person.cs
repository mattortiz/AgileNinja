
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AgileNinja.Model
{

    public enum Gender
    {

        Male = 1, 
        Female = 2, 
        Other = 3

    }

    public class Person
    {


        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public Gender Gender { get; set; }
        public string Suffix { get; set; }

    }

}

