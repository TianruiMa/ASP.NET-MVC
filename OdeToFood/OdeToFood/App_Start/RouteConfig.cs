using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace OdeToFood
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            // avoid reaching out to a real route in the file system
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            
            // THE ORDER OF ADDING ROUTE MATTERS !!!  -  goes by the first match
    
            // new route - /Cuisine/french
            // we dont want every action for each type of Cuisine
            routes.MapRoute("Cuisine",
                            "cuisine/{name}",
                            new {Controller = "Cuisine", action = "Search", name = UrlParameter.Optional});
            

            routes.MapRoute(
                name: "Default",    // Route Name
                url: "{controller}/{action}/{id}",    // URL with parameters
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }    // Parameter defaults
            );
        }
    }
}
