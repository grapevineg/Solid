using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            YourClass m1 = new MyClass();
            Console.Write(m1.yourMethod());
            Console.Read();
        }
    }

}
