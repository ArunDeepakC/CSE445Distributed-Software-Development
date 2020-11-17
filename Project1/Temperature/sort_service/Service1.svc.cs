using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace sort
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public string sort(string s)
        {// Convert String to List
            try
            {
                List<int> s_int = s.Split(',').Select(int.Parse).ToList();
                // Sort the list
                s_int.Sort();
                // Convert sorted list to string and return
                return string.Join(",", s_int);
            }
            catch(Exception e)
            {
                return "Invalid number string!";
            }
            
        }
    }
}
