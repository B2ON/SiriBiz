using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SiriBiz.App.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Blog(string article)
        {
            ViewBag.Article = article;
            return View();
        }

        [Route("Post")]
        public IActionResult Post(string article, string slug = "")
        {
            ViewBag.Article = article;
            ViewBag.Slug = slug;
            return View();
        }
    }
}
