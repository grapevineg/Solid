﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechEd.Demo.SolidPrinciple
{
    public class Customer
    {
        public string FirstName { get; set; }
        public string LastName{ get; set; }
        public string Email { get; set; }

        private bool validate()
        {
            return true;
        }
        public bool save()
        {
            validate();
            return true;
        }

    }
 
}
