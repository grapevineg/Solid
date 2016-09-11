using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechEd.Demo.SolidPrinciple.SRP
{
    public class InvoicePrint
    {
        public void Print(decimal totlaValue)
        {
            Console.Write("Total is :" + totlaValue.ToString());
            Console.Read();
        }
    }
}
