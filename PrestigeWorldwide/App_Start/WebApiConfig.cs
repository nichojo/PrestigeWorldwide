using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace PrestigeWorldwide
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "Distance API",
                routeTemplate: "api/{controller}/{fromAirport}/{toAirport}"
                );
        }
    }
}
