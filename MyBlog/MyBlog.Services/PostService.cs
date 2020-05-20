using System;
using System.Collections.Generic;
using MyBlog.Models;
using MyBlog.Repositories;
using MyBlog.Repositories.Interfaces;
using MyBlog.Services.Interfaces;

namespace MyBlog.Services
{
    public class PostService: IPostService
    {
        public IPostRepository PostRepo { get; set; }
        public PostService(IPostRepository postrepo)
        {
            PostRepo = postrepo;
        }
        public List<Post> GetAll() 
        {
            var posts = PostRepo.GetAll();
            return posts;
        }

        public Post GetById(int id) 
        {
            var post = PostRepo.GetById(id);
            return post;
        }

        public void CreatePost(Post post) 
        {
            PostRepo.Add(post);
        }
    }
}
