using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace FirstWebPage
{
    
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
             AreaRegistration.RegisterAllAreas();//регистрирует все области(разделы сайта со своими иерархиями контроллеров,действий и представлений) в приложении,которые найдёт
             RouteConfig.RegisterRoutes(RouteTable.Routes);
                       
        }
    }
}