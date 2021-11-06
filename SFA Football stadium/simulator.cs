using System;
using System.Collections.Generic;
using System.Text;

//copy of my simulator
namespace SFA_Football_stadium
{
    class simulator
    {
        static void Main(string[] args)
        {
            TaxRate standardRate = new TaxRate(8.25);

            //test changing tax rate
            Console.WriteLine("Rate before change: " + standardRate.CurrentRate());
            standardRate.UpdateRate(10);
            Console.WriteLine("Rate after change" + standardRate.CurrentRate());
            standardRate.UpdateRate(8.25);
            Console.WriteLine("Rate after changing back" + standardRate.CurrentRate());

            //create a new senior customer
            Customer customerOne = new Customer("Dale", new Senior());
            Console.WriteLine("Created a new cusotmer");

            //store the ticket price of the customer into a variable
            double ticketprice = customerOne.CT.TicketPrice();
            Console.WriteLine("The price of ticket before taxes is: " + ticketprice);

            //store the current rate into a variable
            double tax = standardRate.CurrentRate();

            //find the ammount off tax to add to the total
            double total = ticketprice / tax;
            total += ticketprice + total;
            Console.WriteLine("The cost of admission is: " + total);
        }
    }
}
