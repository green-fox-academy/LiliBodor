using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplicationHelloWord.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return Content("Index");
        }

        [Route("hello")]
        public IActionResult Hello()
        {
            return Content("Hello Word!");
        }
    }
}