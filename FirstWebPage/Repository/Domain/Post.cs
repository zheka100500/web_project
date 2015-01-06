using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations; //для того чтобы поставить первичный ключ сущности

namespace FirstWebPage.Repository.Domain
{
    public class Post
    {
        [Key]
        public int id_post { get; set; }
        public string title { get; set; }
        public string body { get; set; }
        public DateTime datecreated { get; set; }
        public virtual ISet<Coments> Comments { get; set; } //virtual для механизма ленивой загрузки.выгружаем только тогда ,когда мы к ним обратимся
    }
}