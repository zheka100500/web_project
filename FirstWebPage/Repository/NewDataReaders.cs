using Database.Models;
using FirstWebPage.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace FirstWebPage.Repository
{
    public class NewDataReaders
    {
        public ArticleModel GetArticleModel(string title)
        {
            PostModel postModel = null;
            Collection<string> comments = null;
            using( var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["mssql"].ConnectionString))   //для закрытия соединения(try,catch,finaly)
            {
                connection.Open();
                using( var command = new SqlCommand("SELECT * FROM Post WHERE title = @title"))
                {
                    command.Connection = connection;
                    command.Parameters.Add(new SqlParameter("title",title));
                    using(var reader = command.ExecuteReader())
                    {
                        if(reader.Read())
                        {
                            postModel = new PostModel(
                                reader["title"].ToString(),
                                reader["body"].ToString(),
                                DateTime.Parse(reader["datecreated"].ToString())
                                );
                        }
                    }
                }

                //поменять запрос когда буду выгружать из таблицы Comment
                using (var command = new SqlCommand("SELECT coments.body FROM Coments INNER JOIN Post ON Coments.id_post = Post.id_post WHERE Post.title = @title"))
                {
                    command.Connection = connection;
                    command.Parameters.Add(new SqlParameter("title", title));
                    comments = new Collection<string>();
                    using (var dataReader = command.ExecuteReader())
                    {
                        while (dataReader.Read())
                        {
                            comments.Add(dataReader["body"].ToString());
                        }
                    }
                }

            }

            return new ArticleModel(postModel,comments);

        }



//==================================================
        public void AddComment(string title, string comment)
        {
            using( var sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["mssql"].ConnectionString))
            {
                 using (var sqlCommand = new SqlCommand(@"INSERT INTO Coments
	                 SELECT id_post, @comment AS MyPost 
                     FROM Post 
                     WHERE title = @title")) 
                {
                     sqlCommand.Parameters.Add(new SqlParameter("comment", comment));
                     sqlCommand.Parameters.Add(new SqlParameter("title", title));
                     sqlCommand.Connection = sqlConnection;
                     sqlConnection.Open();
                     sqlCommand.ExecuteNonQuery();
                }
            }
        }

//==================================================
            
    }
}