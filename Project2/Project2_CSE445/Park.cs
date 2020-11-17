using System;
using System.Collections;
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
    public class Park
    {
        private const int P_MAX = 20; // Constant for Maximum Price Cuts

        private int p = 1; // Counter for the price cuts
        private double currPrice = 0.0; // Current Unit Price for the park visit
        private double prevPrice = 0.0; // Previous Unit Price for the park visit

        private ArrayList processingThreads = new ArrayList();

        public delegate void PriceCutHandler(PriceCutEventArgs e); // Delegate to handle price cut events
        public event PriceCutHandler PriceCut; // Event generated when price cut event occurs


        //Event emitted once the price cut event has occured
        private void PriceCutEvent()
        {
            // Make sure the event is subscribed 
            if (PriceCut != null)
            {
                // Emit the PriceCut event
                Console.WriteLine("\nEVENT #{0}: Price Cut Event for ({1})\n", p, Thread.CurrentThread.Name);
                p++; //Increase the counter
                PriceCut(new PriceCutEventArgs(Thread.CurrentThread.Name, currPrice));
            }
            else
            {
                Console.ResetColor();
                Console.WriteLine("ERROR: No PriceCut event subscribers");
            }
        }

        public void Run()
        {
            // Loop until P_MAX price cuts have occured
            while (p <= P_MAX)
            {
                // Calculate the Unit Price for park visits from the Pricing model
                // Park_0 uses pricing model 1
                // Park_1 uses pricing model 2
                SetPrice();

                if (Program.DEBUG)
                {
                    Console.ResetColor();
                    Console.WriteLine("CHECKING: ({0}) Price Comparison ({1} to {2})",
                        Thread.CurrentThread.Name,
                        prevPrice.ToString("C"),
                        currPrice.ToString("C")
                    );
                }

                // Check if the previous price was greater than the current price
                if (currPrice < prevPrice)
                {
                    // Emit the event because PriceCut has been made
                    PriceCutEvent();
                }

                // Set the Previous Price to the Current Price
                prevPrice = currPrice;

                // Retrieve and Process the orders from the Multi-Cell Buffer
                ProcessOrder(RetrieveOrder());
            }

            foreach (Thread item in processingThreads)
            {
                while (item.IsAlive) ;
            }

            Console.ResetColor();
            Console.WriteLine("CLOSING: Thread ({0})", Thread.CurrentThread.Name);
        }

        // Function to set the current price
        private void SetPrice()
        {

            if (Program.DEBUG)
            {
                Console.ResetColor();
                Console.WriteLine("PRICING: ({0}) Calculating ......", Thread.CurrentThread.Name);
            }

            prevPrice = currPrice;
            // get price from the pricing model class
            currPrice = PricingModel.GetRates();

            if (Program.DEBUG)
            {
                Console.ResetColor();
                Console.WriteLine("PRICING: ({0}) Final Price  = ({1})",
                    Thread.CurrentThread.Name,
                    currPrice.ToString("C")
                );
            }
        }

        private OrderClass RetrieveOrder()
        {
            // decode the string stored in the multi-cell buffer
            return Decoder.DecodeOrder(Program.mcb.getOneCell());
        }

        private void ProcessOrder(OrderClass order)
        {
            // Make sure the order is for the current Park
            if (order.ReceiverId == Thread.CurrentThread.Name || order.ReceiverId == null)
            {
                Console.ResetColor();
                Console.WriteLine("RECEIVING: Order for ({0})", Thread.CurrentThread.Name);
                OrderProcessing processor = new OrderProcessing(order, currPrice); // processing order once it has been read by the park
                Thread processingThread = new Thread(new ThreadStart(processor.ProcessOrder));
                processingThreads.Add(processingThread);
                processingThread.Name = "ProcessingThread_" + Thread.CurrentThread.Name;
                processingThread.Start();
            }
            else
            {
                Console.ResetColor();
                Console.WriteLine("SKIPPING: Order not found for ({0})", Thread.CurrentThread.Name);
            }
        }

    }
}
