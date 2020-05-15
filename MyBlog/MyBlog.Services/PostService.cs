using System;
using System.Collections.Generic;
using MyBlog.Models;
using MyBlog.Repositories;

namespace MyBlog.Services
{
    public class PostService
    {
        public List<Post> GetAll() 
        {
            var repository = new PostRepository();
            return repository.GetAll();
        }

        public Post GetById(int id) 
        {
            var repository = new PostRepository();
            return repository.GetById(id);
        }
    }
}
