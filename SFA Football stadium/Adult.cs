using System;
using System.Collections.Generic;
using System.Text;

namespace SFA_Football_stadium
{
    class Adult : ICustomerType
    {
        public int TicketPrice()
        {
            return 15;
        }
    }
}
