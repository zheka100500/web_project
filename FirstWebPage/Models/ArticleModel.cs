using Database.Models;
using FirstWebPage.Repository;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;

namespace FirstWebPage.Models
{
    public class ArticleModel
    {
        private readonly PostModel post;
        private readonly ICollection<string> comments;

        public ArticleModel()
        {
            
          //  post = new PostModel("Таттатататтата", "хихихихи", DateTime.Now);
         //   comments = CommentsRepository.Comments;
       
        }
        public ArticleModel(PostModel post, ICollection<string> comments)
        {
            this.post = post;
            this.comments = comments;
        }

        
        public PostModel Post
        {
            get
            {
                return post;
            }
        }
        public ICollection<string> Comments
        {
            get { return comments; }

        }

        

        public AddCommentModel NewComment { get; set; }

             
        //public virtual ICollection<LikeModel> Likes { get; set; } //виртуальная чтобы не выгружать это сразу,а только когда обратишься(не забивать память)
    
    }
}