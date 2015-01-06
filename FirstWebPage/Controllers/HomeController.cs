using Database.Models;
using FirstWebPage.Models;
using FirstWebPage.Repository;
using FirstWebPage.Repository.Domain;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstWebPage.Controllers
{
    public class HomeController : Controller
    {

        [HttpGet]
        public ActionResult About()
        {
            return View();
        }

        [HttpGet]
        public ActionResult History()
        {
                       
            return View();          
           

        }
        [HttpGet]
        public ActionResult Index(string title)
        {
            //string query = Request.QueryString["foo"];
            if (title == null)
            {
                title = "Удалённое управление";
            }

            using (var ctx = new EFContext())
            {
                var post = ctx.Posts.Where(p => p.title==title).FirstOrDefault();
                var postModel = new PostModel(post.title, post.body, post.datecreated);
                var commentModel = new Collection<string>();
                if (post.Comments != null && post.Comments.Any())
                {
                    foreach (var item in post.Comments)
                    {
                        commentModel.Add(item.body);
                    }
                }
                return View(new ArticleModel(postModel,commentModel));
            } 

            

           // var readers = new NewDataReaders();//считываем из базы
           // return View(readers.GetArticleModel(title));
        }

        [HttpPost]
        //[ValidateInput(false)] чтобы можо было отправить код из полей ввода
        public ActionResult Index(ArticleModel model)
        {

            var title = "Удалённое управление";
           if (model.NewComment != null && ModelState.IsValid)
           {
             using (var ctx = new EFContext())
             {
                var post = ctx.Posts.Where(p => p.title == title).FirstOrDefault();
                if(post != null)
                {
                    ctx.Comments.Add(new Coments() { body = model.NewComment.Commenttext, id_post = post.id_post });
                    ctx.SaveChanges();
                }
              }

            

          //      var readers = new NewDataReaders();//считываем из базы
          //      readers.AddComment(title, model.NewComment.Commenttext);
                //CommentsRepository.Comments.Add(model.NewComment.Commenttext);
                ModelState.Clear(); //чтобы не оставались комментарии при обновлении страницы в поле ввода комментариев
                return RedirectToAction("Index", new {title = title});
            //     return View(readers.GetArticleModel(title));
           }
            return View(model);
        }



        // public ActionResult AddComment()
        // {
        //    string comment = Request.Form["commenttext"];
        //    return RedirectToAction("Index","Home");
        // }
        //-------------------------------------------------------------
        // public ActionResult AddComment(string commenttext)
        // {
        //    return RedirectToAction("Index","Home");
        // }
        //-------------------------------------------------------------

        //public ActionResult AddComment(AddCommentModel model)
        //  {
        //      return RedirectToAction("index", "home");
        //  }
        //-------------------------------------------------------------
        //[HttpPost] //в этот метод можно зайти только используюя метод post
     //   public ActionResult Index(AddCommentModel model)
      //  {
       //     if (!string.IsNullOrWhiteSpace(model.Commenttext))
       //     {
       //         CommentsRepository.Comments.Add(model.Commenttext);
       //     }
        //    return View(new ArticleModel());
       // }


        public IEnumerable<object> Collection { get; set; }
    }
}
