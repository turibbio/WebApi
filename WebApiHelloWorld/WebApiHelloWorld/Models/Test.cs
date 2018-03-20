using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiHelloWorld.Models
{

    public class Rootobject
    {
        public Contact[] Contacts { get; set; }
    }

    public class Contact
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public string Phone { get; set; }
        public Address Address { get; set; }
    }

    public class Address
    {
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
    }

}