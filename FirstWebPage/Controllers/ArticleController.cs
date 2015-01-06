using FirstWebPage.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstWebPage.Controllers
{
    public class ArticleController : Controller
    {
        public ContentResult Index()
        {
            return new ContentResult() { Content = "Привет" };
        }
        public ContentResult GetByUrl(string seoUrl) 
        {
            return new ContentResult() { Content = "#" + seoUrl + "#"};
        }

        public ActionResult Recent()
        {
            var model = new RecentDataModel();
            return View(model);
        }

    }
}
