using System.Web.Mvc;

namespace FirstWebPage.Areas.Admin
{
    public class AdminAreaRegistration : AreaRegistration
    {
        //namespace - области,в которых объявлены какие-то классы(места их жительства)
        private static readonly string[] Namespaces = new[] { "FirstWebPage.Areas.Admin.Controllers" };//массив из одного элемента
        public override string AreaName
        {
            get
            {
                return "Admin";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "Admin_default",
                "Admin/{controller}/{action}/{id}",
                new { controller = "Home",action = "Index", id = UrlParameter.Optional }
                , namespaces: Namespaces //чтобы показать на какой home контроллер должен обращаться
            );
        }
    }
}
