using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechEd.Demo.SolidPrinciple.OCP
{
    class Program
    {
        static void Main(string[] args)
        {
            var invoice = new Invoice { Subtotal = -1, TaxRate=10 };
            
            List<Validator> val=new List<Validator>();
            val.Add(new InvoiceSubTotalValidator());
            val.Add(new InvoiceTaxRateValidator());

            InvoiceValidator invoiceValidator = new InvoiceValidator(val);

            if (invoiceValidator.Validate(invoice))
            {

            }
        }
    }
}
