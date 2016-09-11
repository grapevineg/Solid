using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechEd.Demo.SolidPrinciple.OCP
{
    public class InvoiceValidator
    {
        List<Validator> _validators;

        public InvoiceValidator(List<Validator> validators)
        {
            _validators = validators; 
        }
        //public bool Validate(Invoice invoice)
        //{
        //    bool flag =true;
        //    if (invoice.Subtotal < 0)
        //        flag = false;
        //    if (invoice.TaxRate < 0)
        //        flag = false;
        //    return flag;
        //}
        public bool Validate(Invoice invoice)
        {
            return _validators.All(x => x.validate(invoice));
        }
    }
}
