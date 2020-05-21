using System;
using System.Collections.Generic;
using System.Linq;
using MyBlog.Models;
using MyBlog.Repositories.Interfaces;

namespace MyBlog.Repositories
{
    public class PostRepository:IPostRepository
    {
        public List<Post> Posts { get; set; }

        public PostRepository()
        {
            Posts = new List<Post>();
            var post1 = new Post()
            {
                Id = 1,
                Title = "Top 10 Benefits of Yoga",
                ImageUrl = "https://dailycupofyoga.files.wordpress.com/2019/09/image.jpg?w=768&h=303&crop=1",
                Description = "By Jen Doyle Yoga is the suppression of the activities of the mind” - Yoga Sutras of Patanjali, c. 4th century CE. Yoga is a mental and physical practice of exercises, poses, and meditation techniques that originated in ancient India…",
                Editor = "Jen Doyle"
            };
            var post2 = new Post()
            {
                Id = 2,
                Title = "Why You Should Consider Fasting & 4 Tips to Prepare for Your First Fast",
                ImageUrl = "https://dailycupofyoga.files.wordpress.com/2019/11/why-you-should-consider-fasting-4-tips-to-prepare-for-your-first-fast.png?w=1024&h=682",
                Description = "By Ram Jain People have been practicing fasting for many years for religious, spiritual or health reasons. Yogic philosophy also approves of fasting as a way to cleanse the body and to control both mind and body.  When you practice…",
                Editor = "Ram Jain"
            };

            var post3 = new Post()
            {
                Id = 3,
                Title = "3 Mantras to Build Your Self - Love",
                ImageUrl = "https://dailycupofyoga.files.wordpress.com/2019/07/img_1145.jpg?w=768&h=303&crop=1  ",
                Description = "You yourself, as much as anybody in the entire universe deserve your love and affection.” Buddha. Self-love. We all need more of it. The teachings of yoga are big on self-love because of one spiritual truth: you cannot fully love others until you fully…",
                Editor = "Aimee Hughes"
            };

            Posts.Add(post1);
            Posts.Add(post2);
            Posts.Add(post3);
        }

        public List<Post> GetAll() 
        {
            return Posts;
        }

        public Post GetById(int id) 
        {
            return Posts.FirstOrDefault(x => x.Id == id);
        }

        public void Add(Post post) 
        {
            var posts = GetAll();
            var maxId = posts.Max(x => x.Id);
            post.Id = maxId + 1;
            Posts.Add(post);
        }
        public List<Post> GetByTitle(string title) 
        {
            throw new NotImplementedException();
        }
    }
}
