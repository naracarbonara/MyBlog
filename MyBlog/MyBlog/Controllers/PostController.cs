using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using MyBlog.Models;
using MyBlog.Services;
using MyBlog.Services.Interfaces;

namespace MyBlog.Controllers
{
    public class PostController : Controller
    {
        public IPostService PostService { get; set; }
        public PostController(IPostService postservice)
        {
            PostService = postservice;
        }
        public IActionResult Overview()
        {
            var posts = PostService.GetAll();
            return View(posts);
        }

        public IActionResult Details(int id)
        {
            var post = PostService.GetById(id);

            return View(post);
        }

        [HttpGet]
        public IActionResult Create()
        {
            Post post = new Post();
            return View(post);
        }

        [HttpPost]
        public IActionResult Create(Post post) 
        {
            if (ModelState.IsValid)
            {
                PostService.CreatePost(post);
                return RedirectToAction("Overview");
            }
            else
            {
                return View(post);
            }
        }
    }
}