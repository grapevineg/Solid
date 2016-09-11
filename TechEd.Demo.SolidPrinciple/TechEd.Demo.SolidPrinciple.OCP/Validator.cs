using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechEd.Demo.SolidPrinciple.OCP
{
    public abstract class Validator
    {
        public abstract bool validate(Invoice invoice);
    }
}
