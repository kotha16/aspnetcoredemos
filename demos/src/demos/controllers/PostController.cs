using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace demos.controllers
{
    public class PostController : Controller
    {
        // GET: /<controller>/
        [HttpGet]
        public IActionResult Create()
            
        {
            var post = new models.Post();

            return View(post);
        }

        [HttpPost]
        public IActionResult Create(models.Post post)
        {
            if (ModelState.IsValid)
            {
                //CreatePostRequest request
            }
            return View(post);
        }
    }
}
