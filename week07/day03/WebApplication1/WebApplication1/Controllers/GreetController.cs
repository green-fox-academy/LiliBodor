using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Services;

namespace WebApplication1.Controllers
{
    public class GreetController : Controller
    {
        private IGreetablecs thePerson;

        public GreetController(IGreetablecs person)
        {
            thePerson = person;
        }

        [HttpGet]
        [Route("/")]
        public IActionResult Index()
        {
            return View(thePerson);
        }

        [HttpPost]
        [Route("/")]
        public IActionResult Index(string name)
        {
            thePerson.Name = name;
            return RedirectToAction("greet");
        }

        [HttpGet]
        [Route("/greet")]
        public  IActionResult Greet()
        {
            return View(thePerson);
        }

        
    }
}