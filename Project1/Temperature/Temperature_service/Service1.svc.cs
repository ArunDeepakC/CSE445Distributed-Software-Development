using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Assignment1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public int c2f(int c)
        {// calculate farenheit value using mathematical formula
            double f = (32 + (c * 9d / 5));
            // Return rounded Integer Value
            return Convert.ToInt32(Math.Round(f, MidpointRounding.AwayFromZero));
           
        }
        public int f2c(int f)
        {// Calculate Celcius value using mathematical formula
            double c = ((f - 32) * 5d / 9);
            //  Return rounded Integer Value
            return Convert.ToInt32(Math.Round(c, MidpointRounding.AwayFromZero));
        }

       
    }
}
