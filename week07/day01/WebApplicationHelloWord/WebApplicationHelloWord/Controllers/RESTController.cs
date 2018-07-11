using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplicationHelloWord.Models;

namespace WebApplicationHelloWord.Controllers
{
    [Route("api")]
    public class RESTController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        static int counter;

        [Route("greeting")]
        public IActionResult Gretting(string name)
        {
            counter++;

            var greeting = new Greeting()
            {
                Id = counter,
                Content = "Hello" + name
            };
            return Ok(greeting);
        }
    }
}