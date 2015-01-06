using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FirstWebPage.Models
{
    public class ResentDataItemModel
    {
        public ResentDataItemModel()
        {
            Text = "Bla bla bla";
            URL = "http://google.com";
            Date = DateTime.Now.AddDays(-1);
            ID = 2;
        }
        public string Text { get; set; }
        public string URL { get; set; }
        public DateTime Date { get; set; }
        public int ID { get; set; }
    }
}