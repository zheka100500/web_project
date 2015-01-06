using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Database.Models
{
    public class PostModel
    {
        private readonly string title, body;
        private readonly DateTime dateCreated;

        public PostModel(string title, string body, DateTime dateCreated)
        {
            this.title = title;
            this.body = body;
            this.dateCreated = dateCreated;
        }

        public PostModel()
        {
            // TODO: Complete member initialization
        }

        public string Title
        {
            get
            {
                return title;
            }
        }

        public string Body
        {
            get
            {
                return body;
            }
        }

        public DateTime DateCreated
        {
            get
            {
                return dateCreated;
            }
        }
    }
}