using System;
using System.Collections.Generic;
using System.Text;

namespace SFA_Football_stadium
{
    class Customer
    {
        string name;
        ICustomerType ct;
        public ICustomerType CT { get; set; }

        public Customer(string name, ICustomerType ct)
        {
            this.CT = ct;
            this.name = name;
            
        }
    }
}
