using System;
using System.Collections.Generic;
using System.Text;

namespace SFA_Football_stadium
{
    //interface which determines the type of customer
    //and allows for more ticket categories to be made
    interface ICustomerType
    {
        public int TicketPrice();

    }
}
