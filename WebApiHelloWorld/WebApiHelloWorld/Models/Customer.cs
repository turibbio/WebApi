using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiHelloWorld.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cognome { get; set; }
    }
}