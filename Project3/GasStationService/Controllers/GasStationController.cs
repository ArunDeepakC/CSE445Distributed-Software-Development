using GasStationService.Controllers;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web;
using System.Web.Http;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace GasStationService.Controllers
{
    //Restful service that that takes address as input and returns the details about nearest gas stations
    //Details- Gas station name, street address, Fuel type- eg. CNG, LPG, Electric, Facility type- eg. grocery store
    public class GasStationController : ApiController
    {
        //Set controller to return gas station service response
        public List<string> Get(string address)
        {

            return GasStationOperation.GetGasStations(address);

        }

    }
    public class GasStationOperation
    {    
   
       
        public static List<string> GetGasStations(string address)
        {
            //Getter-Setter to initialize location - latitude and longitude
            Location location = new Location();
            location.lat = 0.00;
            location.lng = 0.00;
                       
            // API 1- Google's geocode api
            //Convert address to Latitude longitude using Google's geocode API by generating a key
         
            HttpWebRequest geocodeRequest = (HttpWebRequest)WebRequest.Create(
               "https://maps.googleapis.com/maps/api/geocode/xml?address=" + HttpUtility.UrlEncode(address) + "&key=AIzaSyB1cZN-z7RlmiK-4XERcUAzdaapZaiL4PQ"
           );
           // System.Diagnostics.Trace.WriteLine(geocodeRequest);
           
            //Set request method from geocode api as Get
            geocodeRequest.Method = "GET";
            
            //Obtain http response from geocode api
            HttpWebResponse geocodeResponse = (HttpWebResponse)geocodeRequest.GetResponse();
            try
            {
                // Make sure HTTP response is received
                if (geocodeResponse.StatusCode == HttpStatusCode.OK)
                {
                    //obtain XML document from api
                    var xdoc = XDocument.Load(geocodeResponse.GetResponseStream());

                    //Insert values from XML response to object using getter setter
                    var result = xdoc.Element("GeocodeResponse").Element("result");
                    var locationElement = result.Element("geometry").Element("location");
                    var lat = locationElement.Element("lat");
                    var lng = locationElement.Element("lng");

                    //obtain latitude and longitude values of a given address
                    location.lat = double.Parse(lat.Value);
                    location.lng = double.Parse(lng.Value);


                }
                else
                {
                    //If response fails return empty list
                    return new List<string>();
                }
            }
            catch(Exception)
            { List<string> exception=new List<string>();
                exception.Add("Invalid Address!");
                return exception;
            }

            //API 2 National renewable energy laboratory's nearest fuel stations api
            WebClient client = new WebClient();
            string data=client.DownloadString("https://developer.nrel.gov/api/alt-fuel-stations/v1/nearest.xml?latitude=" + location.lat.ToString() + "&longitude=" + location.lng.ToString() + "&api_key=XJNsm9FkvNEeK5ByCYPuRYVj2SdwM8drb5KLIZ6W");

            // Load xml response from api as XML DOM object 
            XmlDocument xd = new XmlDocument();
            xd.LoadXml(data);

            //Select nodes with the following path
            XmlNodeList fuel = xd.SelectNodes("response/fuel-stations/fuel-station");
            
            //List to store results
      
            GasStationList list;
            List<GasStationList> gs = new List<GasStationList>();

           // Parse through XML tree nodes and use getter-setter to deserialze to object 
            foreach (XmlNode element in fuel)
            {
                list = new GasStationList();
               
                list.station_name = element["station-name"].InnerText;
                list.station_address = element["street-address"].InnerText;
                list.station_type = element["facility-type"].InnerText;
                list.fuel_type = element["fuel-type-code"].InnerText;
                gs.Add(list);               
              
              
                }        
            
            // Add object elements to a list
            List<string> gas_stations = new List<string>();
            foreach (var obj in gs)
            {
                gas_stations.Add("station name:" + obj.station_name + " address:" + obj.station_address + " fuel type:" + obj.fuel_type + " station_type:" + obj.station_type);
            }

            //return the gas station values as a list
            return gas_stations;
            }

         
        }

    //Getter Setter for location latitude and longitude
    public class Location
    {
        public double lat { get; set; }
        public double lng { get; set; }
    }

  //Getter Setter for gas station details
    public class GasStationList
    {
        public string station_name { get; set; }
        public string station_address { get; set; }

        public string fuel_type { get; set; }
        public string station_type { get; set; }


    }

    

    
}