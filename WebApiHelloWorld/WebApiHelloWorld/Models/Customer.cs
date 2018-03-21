using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApiHelloWorld.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(10)]
        public string Nome { get; set; }
        [MaxLength(10)]
        public string Cognome { get; set; }
    }
}