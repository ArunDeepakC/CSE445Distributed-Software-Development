using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using static Project2_CSE445.Program;

/// CONTRIBUTION:
/// Name:   Arun Deepak Chandrasekar
/// ASUID:  1217200647
/// Email:  achand66@asu.edu
/// Class:  CSE-445 (#96279)

namespace Project2_CSE445
{
    public class OrderProcessing
    {
        public static event orderProcessedEvent orderProcessed; // Event that emit the order confirmation callback to the travel agency
        private const double CALC_TAX = 1.08; // rate of tax = 8%. After calculation, CALC_TAX is the amount to be added to final price
        private const double LOCATION_CHARGE = 50.0;  //location charge, chosen to be equal to 50
        private const string CC_REGEX = "^(?:4[0-9]{12}(?:[0-9]{3})?|5[1-5][0-9]{14}|6(?:011|5[0-9][0-9])[0-9]{12}|3[47][0-9]{13}|3(?:0[0-5]|[68][0-9])[0-9]{11}|(?:2131|1800|35\\d{3})\\d{11})$";

        private OrderClass order;
        private double unitPrice;
        private double final_price;

        // constructor
        public OrderProcessing(OrderClass order, double unitPrice)
        {
            this.Order = order;
            this.UnitPrice = unitPrice;
        }

        // method to process the order
        public void ProcessOrder()
        {
            if (order != null)
            {

                if (order.UnitPrice == 0)
                {
                    order.UnitPrice = unitPrice;
                }

                Console.ResetColor();
                Console.WriteLine("PROCESSING: Order for {0}: {1}", Thread.CurrentThread.Name, order.ToString());

                // Check if the credit card number is valid or not
                if (ValidateCreditCard(order.CardNo))
                {
                    Console.ResetColor();
                    Console.WriteLine("CREDIT CARD VALIDATED: {0}", Thread.CurrentThread.Name);
                }
                else
                {
                    Console.ResetColor();
                    Console.WriteLine("CREDIT CARD INVALID: {0}", Thread.CurrentThread.Name);
                    return;
                }

                // displaying processed order
                Console.ResetColor();
                final_price = CALC_TAX * order.Amount * unitPrice + LOCATION_CHARGE;
                Console.WriteLine("PROCESSED: Order for {0}: {1}\n\tTOTAL PRICE: {2}",
                    Thread.CurrentThread.Name, order.ToString(),
                    (final_price).ToString()
                );
                orderProcessed(order, final_price);
            }
            else
            {
                Console.ResetColor();
                Console.WriteLine("NO ORDER RECEIVED: {0}", Thread.CurrentThread.Name);
            }
        }

 
        // function to comapre the credit card number with the regex
        private bool ValidateCreditCard(long ccNum)
        {
            return Regex.IsMatch(ccNum.ToString(), CC_REGEX);
        }

        // getter-setter for the order
        public OrderClass Order
        {
            get { return order; }
            private set { order = value; }
        }

        // getter-setter for the Unit Price
        public double UnitPrice
        {
            get { return unitPrice; }
            set { unitPrice = value; }
        }

    }
}
