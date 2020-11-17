using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// CONTRIBUTION:
/// Name:   Rishti Gupta
/// ASUID:  1217211814
/// Email:  rgupta75@asu.edu
/// Class:  CSE-445 (#96279)

///AND

/// Name:   Arun Deepak Chandrasekar
/// ASUID:  1217200647
/// Email:  achand66@asu.edu
/// Class:  CSE-445 (#96279)

namespace Project2_CSE445
{
    // Class for driving the EventArgs. 
    // Sets the Park Id and Current Price (Unit Price) and passes to the TravelAgency Class.
    public class PriceCutEventArgs : EventArgs
    {
        private double price;
        private string id;

        // constructor
        public PriceCutEventArgs(string id, double price)
        {
            this.Id = id;
            this.Price = price;
        }

        // getter-setter for Park Id
        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        // getter-setter for Unit Price
        public double Price
        {
            get { return price; }
            set { price = value; }
        }

    }
}
