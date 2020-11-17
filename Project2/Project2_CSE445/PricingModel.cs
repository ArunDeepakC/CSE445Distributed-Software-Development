using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


/// CONTRIBUTION:
/// Name:   Arun Deepak Chandrasekar
/// ASUID:  1217200647
/// Email:  achand66@asu.edu
/// Class:  CSE-445 (#96279)

namespace Project2_CSE445
{
    class PricingModel
    {

        static Random rnd = new Random(); // To generate random numbers
        private static Int32 parkPrice = 80; //initial price for a ticket
        private static Int32 holidayStatus; // to determine if the current day is a holiday or not
        static Int32 price; // final price calculated by the pricing model
        static double discount = 0.2; // 20% discount to be given if the order amount exceeds certain limit

        // function that return the price set by the pricing model
        public static Int32 GetRates() { 

            if(Thread.CurrentThread.Name == "Park_0")
            {
                // call price model 1 
                parkPrice = pricingModel_park1();
            }
            else
            {
                // call price model 2
                parkPrice = pricingModel_park2();
            }
            return parkPrice; 
        }

        private static Int32 pricingModel_park1()
        {
            // price depending on the day of the week. Saturdays and Sundays cost more than rest of the week days
            int[] weights_daysOfWeeks = new int[7] { 100, 100, 150, 200, 250, 300, 300 };
            // randomly selecting if the day is a holiday or not
            holidayStatus = rnd.Next(0, 2);
            // multiply the random generated value with the weights depending on the day of the week
            // add $25 extra to the whole price if it is a holiday
            Int32 price = (weights_daysOfWeeks[rnd.Next(0, 7)] + holidayStatus * 25);
            return price;
        }

        private static Int32 pricingModel_park2()
        {
            string order = Program.mcb.getOneCell(); //retrieves the order from the MultiCellBuffer
            OrderClass orderObject = Decoder.DecodeOrder(order); //decodes the encoded string

            //get the amount of order
            int amount = orderObject.Amount;

            // apply a discount of 20% if the order amount is greater than 50
            if (amount < 50)
            {
                price = rnd.Next(80, 200);
            }
            else
            {
                Int32 tmp_price = (rnd.Next(100, 200)); // randomly generate a temporary price
                price = tmp_price - (int)(tmp_price * discount);
            }


            return price;

        }
    }
}
