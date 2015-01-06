using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations; //для того чтобы поставить первичный ключ сущности


namespace FirstWebPage.Repository.Domain
{
    public class Coments
    {
        [Key]
        public int id_comments { get; set; }
        public int id_post { get; set; }
        public Post Post { get; set; }
        public string body { get; set; }
    }
}