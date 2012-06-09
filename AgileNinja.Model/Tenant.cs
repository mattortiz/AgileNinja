
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AgileNinja.Model
{

    public class Tenant : EntityBase 
    {

        public string Name { get; set; }
        public Country Country { get; set; }
        public Language Language { get; set; }
        public Person AccountOwner { get; set; }
        public Address Address { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailAddress { get; set; }

    }

}

