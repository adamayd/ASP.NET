using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExploreCalifornia.Models;
using Microsoft.AspNetCore.Mvc;

namespace ExploreCalifornia.Controllers
{
    [Route("blog")]
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            var posts = new[]
            {
                new Post
                {
                    Title = "My Blog Post",
                    Posted = DateTime.Now,
                    Author = "Adam Ayd",
                    Body = "This is a great blog post, don't you think?"
                },
                new Post
                {
                    Title = "My Blog Post",
                    Posted = DateTime.Now,
                    Author = "Adam Ayd",
                    Body = "This is a ANOTHER great blog post, don't you think?"
                }
            };

            return View(posts);
        }

        [Route("{year:min(2000)}/{month:range(1,12)}/{key}")]
        public IActionResult Post(int year, int month, string key)
        {
            var post = new Post
            {
                Title = "My Blog Post",
                Posted = DateTime.Now,
                Author = "Adam Ayd",
                Body = "This is a great blog post, don't you think?"
            };

            return View(post);
        }
    }
}