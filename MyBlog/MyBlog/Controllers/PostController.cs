using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using MyBlog.Services;

namespace MyBlog.Controllers
{
    public class PostController : Controller
    {
        public IActionResult Overview()
        {
            var service = new PostService();
            var posts = service.GetAll();
                return View(posts);
        }

        public IActionResult Details(int id)
        {
            var service = new PostService();
            var post = service.GetById(id);

            return View(post);
        }
    }
}