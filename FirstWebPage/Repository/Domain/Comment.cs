using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations; //для того чтобы поставить первичный ключ сущности


namespace FirstWebPage.Repository.Domain
{
    public class Comment
    {
        [Key]
        public int id_comment { get; set; }
        public int id_post { get; set; }
        public Post Post { get; set; }
        public string body { get; set; }
        public string login { get; set; }
        public string mail { get; set; }
        public DateTime date_comment { get; set; }

    }
}