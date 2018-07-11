using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication2.Model;
using WebApplication2.Services;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        private HomeService homeService;

        public HomeController(HomeService homeService)
        {
            this.homeService = homeService;
        }

        [HttpGet("/")]
        public IActionResult Index()
        {
            return File("index.html", "text/html");
        }

        [HttpGet("/doubling")]
        public IActionResult Doubling(int? input)
        {
            if (input == null)
            {

                 return Json(new { error = "Please provide an input!" });
            }
            else
            {
                return Json(new { received = input, result = input * 2 });
            }
        }

        [HttpGet("/greeter")]
        public IActionResult Greeter(string name, string title)
        {
            if (name == null)
            {
                return Json(new { error = "Please provide a name!" });
            }
            else if (title == null)
            {
                return Json(new { error = "Please provide a title!" });
            }
            else
            {
                return Json(new { welcome_message = $"Oh, hi there {name}, my dear {title}!" });
            }
        }

        [HttpGet("/appenda/{appendable}")]
        public IActionResult AppendA(string appendable)
        {
                return Json(new { appended = appendable + "a" });
        }

        [HttpGet("/appenda")]
        public IActionResult AppendA()
        {
            return NotFound();
        }

        [HttpPost("/dountil/{what}")]
        public IActionResult DoUntil(string what, [FromBody] Number doUntil )
        {
            if (doUntil == null ||doUntil.Until==null)
            {
                return Json(new { error = "Please provide a number!" });
            }
            else
            {
                if (what == "sum")
                {
                    return Json(new { result = homeService.Sum(doUntil) });
                }
                else if (what == "factor")
                {
                    return Json(new { result = homeService.Factor(doUntil) });
                }
            }
            return Json(new { error = "Please provide an input!" });
        }

        [HttpPost("/arrays")]
        public IActionResult Arrays([FromBody] WithArray array)
        {
            if (array == null || array.Numbers == null)
            {
                return Json(new { error = "Please provide a number!" });
            }
            else
            {
                if (array.What == "sum")
                {
                    return Json(new { result = homeService.Sum(array) });
                }
                else if (array.What == "multiply")
                {
                    return Json(new { result = homeService.Multiply(array) });
                }
                //else if (what == "double")
                //{
                //    return Json(new { result = array.Double() });
                //}
            }
            return Json(new { error = "Please provide an input!" });
        }

    }
}