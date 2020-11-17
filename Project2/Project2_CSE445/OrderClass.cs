using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// CONTRIBUTION:
/// Name:   Rishti Gupta
/// ASUID:  1217211814
/// Email:  rgupta75@asu.edu
/// Class:  CSE-445 (#96279)

namespace Project2_CSE445
{
    public class OrderClass
    {
        private string senderId; // The identity of TravelAgency which sets the order
        private string receiverId; // The identity of the Park which receives the order
        private long cardNo; // An integer that represents a credit card number
        private int amount; // Number of tickets ordered
        private double unitPrice; // Cost of one ticket 
        private DateTime dateCreated = DateTime.Now; // Time the order is placed

        public override string ToString()
        {
            return "ORDER\n\t{ID: " + SenderId
                + "}\n\t{RECEIVER_ID: " + ReceiverId
                + "}\n\t{CARD_NO: " + CardNo
                + "}\n\t{AMOUNT: " + Amount
                + "}\n\t{UNIT_PRICE: " + UnitPrice
                + "}\n\t{CREATED: " + DateCreated.ToString("d", CultureInfo.InvariantCulture) + "}";
        }


        // getter-setter for timestamp
        public DateTime DateCreated
        {
            get { return dateCreated; }
            set { dateCreated = value; }
        }

        // getter-setter for senderId
        public string SenderId
        {
            get { return senderId; }
            set { senderId = value; }
        }

        // getter-setter for receiverId
        public string ReceiverId
        {
            get { return receiverId; }
            set { receiverId = value; }
        }


        // getter-setter for Credit card Number
        public long CardNo
        {
            get { return cardNo; }
            set { cardNo = value; }
        }

        // getter-setter for number of tickets
        public int Amount
        {
            get { return amount; }
            set { amount = value; }
        }

        // getter-setter for price of one ticket
        public double UnitPrice
        {
            get { return unitPrice; }
            set { unitPrice = value; }
        }

    }
}
