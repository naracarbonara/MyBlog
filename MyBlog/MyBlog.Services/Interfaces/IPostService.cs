using System;
using System.Collections.Generic;
using System.Text;
using MyBlog.Models;

namespace MyBlog.Services.Interfaces
{
    public interface IPostService
    {
        List<Post> GetAll();
        Post GetById(int id);
        void CreatePost(Post post);
    }
}