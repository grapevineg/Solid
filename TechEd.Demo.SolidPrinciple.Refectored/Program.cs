using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechEd.Demo.SolidPrinciple.Refectored
{
    class Program
    {
        static void Main(string[] args)
        {
            Invoice inv = new Invoice();
            inv.Print(inv.CalculateTotal());
        }
  
    }
}
