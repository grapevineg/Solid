using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechEd.Demo.SolidPrinciple
{
    public class Invoice
    {
        public decimal Subtotal { get; set; }
        
        public decimal TaxRate { get; set; }

        public decimal CalculateTax()
        {
            return (Subtotal * TaxRate / 100);
        }

        public decimal CalculateTotal()
        {
            return Subtotal + CalculateTax();
        }

        public void Print(decimal totlaValue)
        {
            Console.Write("Total is :" + totlaValue.ToString());
            Console.Read();
        }
    }
}
