using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;

namespace FirstWebPage.Models
{
    public class RecentDataModel
    {
        public RecentDataModel()
        {
            Items = new Collection<ResentDataItemModel>();
            Items.Add(new ResentDataItemModel());
            Items.Add(new ResentDataItemModel());
            Items.Add(new ResentDataItemModel());

        }
        public virtual ICollection<ResentDataItemModel> Items { get; set; } //создание коллекции типа ResentPostItemModel под названием Items 
    }
}