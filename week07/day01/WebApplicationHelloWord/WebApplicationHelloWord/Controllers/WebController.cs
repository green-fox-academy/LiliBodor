using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplicationHelloWord.Models;

namespace WebApplicationHelloWord.Controllers
{
    [Route("web")]
    public class WebController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        static int counter;

        [Route("greeting")]
        public IActionResult Greeting(string name)
        {
            counter++;

            var greeting = new Greeting()
            {
                Id = counter,
                Content = name
            };

            return View(greeting);
        }

        [Route("greettheworld")]
        public IActionResult GreeatTheWorld(string name)
        {
            var greettheworld = new GreetTheWorld()
            {
                Name = name
            };

            return Ok(greettheworld);
        }

    }
}