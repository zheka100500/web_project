using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstWebPage.Repository
{
    public class CommentsRepository 
    {
        public static readonly ICollection<string> Comments = new Collection<string>();
        
    }
}
