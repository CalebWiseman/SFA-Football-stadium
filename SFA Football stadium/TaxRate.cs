using System;
using System.Collections.Generic;
using System.Text;

namespace SFA_Football_stadium
{
    //class to easily make tax rate changes
    class TaxRate
    {
        double rate;

        public TaxRate(double rate)
        {
            this.rate = rate;
        }
       
        //update the tax rate rather than creating a new TaxRate
        public void UpdateRate(double update)
        {
            this.rate = update;
        }

        public double CurrentRate()
        {
            return rate;
        }
    }
}
