using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Macrotis.Models;
using Macrotis.Services;
using Microsoft.AspNetCore.Mvc;

namespace Macrotis.Controllers
{
 
    public class AttractionsController : Controller
    {
        private AttractionService attractionService;

        public AttractionsController(AttractionService attractionService)
        {
            this.attractionService = attractionService;
        }

        public IActionResult Index()
        {
            return View(attractionService.GetAttractions());
        }

        [HttpPost("/add")]
        public IActionResult AddAttraction(Attractions attraction)
        {
            attractionService.AddAttractions(attraction);
            return RedirectToAction("Index");
        }

        [HttpPost("/edit")]
        public IActionResult EditAttraction(Attractions attraction)
        {
            attractionService.EditAttraction(attraction);
            return RedirectToAction("Index");
        }
    }
}