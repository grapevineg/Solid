using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechEd.Demo.SolidPrinciple.OCP
{
    public class InvoiceSubTotalValidator : Validator
    {
        public override bool validate(Invoice invoice)
        {
            bool flag = true;
            if (invoice.Subtotal < 0)
                flag = false;
            return flag;
        } 
    }
}
