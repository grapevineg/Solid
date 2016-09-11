using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TechEd.Demo.SolidPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer
            {
                 FirstName ="abc",
                 LastName= "def",
                 Email="abc@gmail.com"
             
            };
            customer.save();
        }
    }
}
