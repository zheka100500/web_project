using FirstWebPage.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstWebPage.Controllers
{
    public class CommentController : Controller
    {
        
        public ActionResult Recent()
        {
            var model = new RecentDataModel();
            return View(model);
        }
       public ContentResult Index()
        {
            return new ContentResult() { Content = "Привет" };
        }
        public ContentResult ById(int id)
        {
            return new ContentResult() { Content = "Это коментарий #" + id };
        }
        

    }
}
