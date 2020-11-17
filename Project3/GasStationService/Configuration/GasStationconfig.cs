using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace GasStationService.Configuration
{
    public class GasStationconfig
    { //Configure the end point
        public static void Register(HttpConfiguration config)
        {   // set Web API routes
            config.MapHttpAttributeRoutes(); 
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{address}"
                
            );
        }

    }
}