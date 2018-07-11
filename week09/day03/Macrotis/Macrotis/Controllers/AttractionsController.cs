using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Macrotis.Controllers
{
    public class AttractionsController : Controller
    {

        [HttpPost("/add")]
        public IActionResult AddAttraction(Attractions attractions)
        {
            return View();
        }
    }
}