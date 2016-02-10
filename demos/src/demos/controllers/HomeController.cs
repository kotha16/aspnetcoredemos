using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace demos.controllers
{
    public class HomeController : Controller
    {
        //// GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Post(int id)
        {
            var post = new models.Post();
            post.Title = "Hello World";
            return View(post);
        }

        public IActionResult CauseAnError()
        {
            throw new Exception("This is a test error");
        }

        //public string Index()
        //{
        //    return "Hello aspnet.core!";
        //}

        // public string Echo(string id)
        //{
        //    return id;
        //}
    }
}
