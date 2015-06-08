using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace RouteExample
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "wiki",
                url: "documents/{*path}",
                defaults: new { controller = "Documents", action = "GetDocument" }
                );

            routes.MapRoute(
                name: "BlogById",
                url: "blog/{entryId}",
                defaults: new { controller = "Blog", action = "GetEntryById" },
                constraints: new {entryId=@"\d+"}
                );


            routes.MapRoute(
                name: "BlogByDate",
                url: "blog/{entryDate}",
                defaults: new { controller = "Blog", action = "GetEntryByDate" }
                );



            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
