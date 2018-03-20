using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiHelloWorld.Models;

namespace WebApiHelloWorld.Controllers
{
    public class CustomerController : ApiController
    {
        List<Customer> customerList;

        public CustomerController()
        {
             customerList = new List<Customer>
            {
                new Customer { Id = 1, Cognome = "Liccardi", Nome = "Antonio"},
                new Customer { Id = 2, Cognome = "Liccardi", Nome = "Antonio"}
            };
        }

        public List<Customer> Get()
        {
            return customerList;
        }

        public Customer Get(int id)
        {
            return customerList.FirstOrDefault(x => x.Id == id);
        }

        public Customer Get(int id, string nome)
        {
            return customerList.FirstOrDefault(x => x.Id == id && x.Nome == nome);
        }

        public void Post([FromBody]Customer customer)
        {
            customerList.Add(customer);
        }
    }
}
