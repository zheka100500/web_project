using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstWebPage.Models
{
    public class AddCommentModel 
    {
        [Required (ErrorMessage = "Пожалуйста, введите логин")]  //коммент всё равно добавляется.не работает защита
        [Display(Name = "логин")]
        [StringLength(20)]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Пожалуйста, введите свой email")]
        [Display(Name = "email")]
        [StringLength(25)]
        //[RegularExpression(@"")] проверка на соответствие регулярному выражению
        public string Mail { get; set; }
        [Required(ErrorMessage = "Пожалуйста, введите текст комментария")]
        [Display(Name = "комментарий")]
        [StringLength(250)]
        public string Commenttext { get; set; }
    }   
}
