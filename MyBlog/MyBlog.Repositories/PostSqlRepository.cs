using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using MyBlog.Models;
using MyBlog.Repositories.Interfaces;

namespace MyBlog.Repositories
{
    public class PostSqlRepository:IPostRepository
    {
        public void Add(Post post) 
        {
            using (var cnn = new SqlConnection("Data Source=.\\SQLEXPRESS; Initial Catalog=MyBlogSqlDemo; Integrated Security=true"))
            {
                cnn.Open();
                var query = @"Insert into posts(Title, Description, ImageUrl, Editor) values
                    (@Title, @Description, @ImageUrl, @Editor)";
                var cmd = new SqlCommand(query, cnn);
                cmd.Parameters.AddWithValue("@Title", post.Title);
                cmd.Parameters.AddWithValue("@Description", post.Description);
                cmd.Parameters.AddWithValue("@ImageUrl", post.ImageUrl);
                cmd.Parameters.AddWithValue("@Editor", post.Editor);
                cmd.ExecuteNonQuery();
            }

        }
        public List<Post> GetAll()
        {
            var result = new List<Post>();
            using (var cnn = new SqlConnection("Data Source=.\\SQLEXPRESS; Initial Catalog=MyBlogSqlDemo; Integrated Security=true"))
            {
                cnn.Open();
                var cmd = new SqlCommand("Select * from posts", cnn);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    var post = new Post();
                    post.Id = reader.GetInt32(0);
                    post.Title = reader.GetString(1);
                    post.Description = reader.GetString(2);
                    post.ImageUrl = reader.GetString(3);
                    post.Editor = reader.GetString(4);
                    result.Add(post);
                }
               
            }
            return result;
        }

        public Post GetById(int id) 
        {
            Post result =  null;
            using (var cnn = new SqlConnection("Data Source=.\\SQLEXPRESS; Initial Catalog=MyBlogSqlDemo; Integrated Security=true")) 
            {
                cnn.Open();
                var cmd = new SqlCommand($"select * from posts where id={id}", cnn);
                var reader = cmd.ExecuteReader();
                while (reader.Read()) 
                {
                    result = new Post();
                    result.Id = reader.GetInt32(0);
                    result.Title = reader.GetString(1);
                    result.Description = reader.GetString(2);
                    result.ImageUrl = reader.GetString(3);
                    result.Editor = reader.GetString(4);
                }
            }
            return result;
            


        }

        public List<Post> GetByTitle(string title) 
        {
            var result = new List<Post>();
            using (var cnn = new SqlConnection("Data Source=.\\SQLEXPRESS; Initial Catalog=MyBlogSqlDemo; Integrated Security=true")) 
            {
                cnn.Open();
                var query = "select * from posts";
                if (!String.IsNullOrEmpty(title)) 
                {
                    query = $"{query} where title like @title"; 
                }

                var cmd = new SqlCommand(query, cnn);

                if (!String.IsNullOrEmpty(title)) 
                {
                    cmd.Parameters.AddWithValue("@title", $"%{title}%");
                }
               var reader= cmd.ExecuteReader();
                while(reader.Read())
                {
                    Post post = new Post();
                    post.Id = reader.GetInt32(0);
                    post.Title = reader.GetString(1);
                    post.Description = reader.GetString(2);
                    post.ImageUrl = reader.GetString(3);
                    post.Editor = reader.GetString(4);
                    result.Add(post);
                }
            }
            return result;
        }
    }
}
