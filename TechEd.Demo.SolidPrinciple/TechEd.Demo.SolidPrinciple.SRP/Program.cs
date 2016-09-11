using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechEd.Demo.SolidPrinciple.SRP
{
    class Program
    {
        static void Main(string[] args)
        {
            var inv = new Invoice { Subtotal = 100, TaxRate = 3 };
            InvoicePrint ip = new InvoicePrint();
            ip.Print(inv.CalculateTotal());
        }
    }
}
