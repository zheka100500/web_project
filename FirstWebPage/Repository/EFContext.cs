using FirstWebPage.Repository.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace FirstWebPage.Repository
{
    public class EFContext : DbContext
    {
        public EFContext(): base("mssql")   //конструктор использует имя строки подключения
        {

        }
        //DbSet - множество,описанное для базы данных
        public DbSet<Post> Posts { get; set; } //  коллекция уникальных записей в базе (data base set) типа  post

        public DbSet<Coments> Comments { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}