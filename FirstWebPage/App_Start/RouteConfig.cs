using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace FirstWebPage
{
    public class RouteConfig
    {
        private static readonly string[] Namespaces = new[] {"FirstWebPage.Controllers"};
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

           // routes.MapMvcAttributeRoutes(); не работает

            routes.MapRoute("Post", "post-{title}", new { controller = "Home", action = "Index"});

            routes.MapRoute(
               name: "article",
               url: "article-{seoUrl}",
               defaults: new { controller = "Article", action = "GetByUrl", seoUrl = string.Empty }
          );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }//если чего-то не найдено,то считать что контроллер хом и т.д.
                , namespaces: Namespaces
            );

            routes.MapRoute(
               name: "Default1",
               url: "{controller}/{action}/{id}",
               defaults: new { controller = "Home", action = "About", id = UrlParameter.Optional }//если чего-то не найдено,то считать что контроллер хом и т.д.
               , namespaces: Namespaces
           );

            routes.MapRoute(
               name: "Default2",
               url: "{controller}/{action}/{id}",
               defaults: new { controller = "Home", action = "History", id = UrlParameter.Optional }//если чего-то не найдено,то считать что контроллер хом и т.д.
               , namespaces: Namespaces
           );
        }
    }
}