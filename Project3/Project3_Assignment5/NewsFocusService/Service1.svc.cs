using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Net;
using System.IO;
using System.Xml;
using System.Web;
using Newtonsoft.Json.Linq;

namespace NewsFocusService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
//Class to store the list of urls returned by Guardian API
    public class New
    {

        public string url;
        public string url_string()
        {
            return this.url;
        }
    }

    // Service to return relevant URL's where the given list of topics are reported using the Guardian open platform
    public class Service1 : IService1
    {


        public string[] NewsFocus(string[] topics)
        {
            try
            {
                WebClient client = new WebClient();
                string tempString = null;
                // Generate the URL to access the guardian API
                string url = "http://content.guardianapis.com/search?q=";

                // Obtaining the topics
                for (int i = 0; i < topics.Length; i++)
                {
                    tempString += topics[i] + " ";
                }
                // binding the topics to url
                url += tempString;
                // Developer key to access guardian opensource platform
                url += "&api-key=95512548-ca22-4933-90e1-57215ef6597f";
                //Download the API response 
                string response = client.DownloadString(url);
                dynamic parsed = JObject.Parse(response);
                int count = parsed.response.pageSize;
                // Translating JSON response into the New class
                New[] news_obj = new New[count];
                for (int i = 0; i < count; i++)
                {
                    news_obj[i] = new New();
                    news_obj[i].url = Convert.ToString(parsed["response"]["results"][i]["webUrl"]);
                }
                // Obtain the array of strings form of the URLs and return the result
                string[] result = new string[count];

                for (int i = 0; i < count; i++)
                {
                    result[i] = news_obj[i].url_string();
                }
                return result;
            }
            catch(Exception)
            { // Exception handling in case invalid entry is made
                return null;
            }
            
        }
    }

}
