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

            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");


            // UrlParameter.Optional  <- it's okay if the input does not exist, and can use query string ?name=italian
            routes.MapRoute("Cuisine", "cuisine/{name}",
                new {controller = "Cuisine", action = "Search", name = UrlParameter.Optional });

            // /Home/index/??    - /controller_name/action_name/id_by_default
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
