using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace NaturalHazardService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    { 
        //Operation Natural Hazards to return natural hazard index given a locations latitude and longitude
        public decimal NaturalHazards(decimal latitude, decimal longitude)
        {
                //Obtain current date
                string date = DateTime.Now.ToString("yyyy-MM-dd");

                // construct the URL of the USGS API with parameters latitude, longitude, current date
                string URL = "https://earthquake.usgs.gov/fdsnws/event/1/count?starttime=1917-09-23&endtime=" + date + "&latitude=" + latitude + "&longitude=" + longitude + "&maxradiuskm=100&minmagnitude=2.5&eventtype=earthquake&orderby=time";
                decimal count = 0;
                var response = "";
            //Obtain the API response to request
                using (WebClient client = new WebClient())
                {
                    response = client.DownloadString(URL);
                }
                count = Convert.ToDecimal(response);        
            
            // return the natural hazard index value
           
            return count;
        }
    }
}

