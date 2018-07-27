using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ma3x.Services;
using Microsoft.AspNetCore.Mvc;

namespace Ma3x.Controllers
{
    public class MatrixController : Controller
    {
        private MatrixService matrixService { get; set; }

        public MatrixController(MatrixService matrixService)
        {
            this.matrixService = matrixService;
        }

        [HttpGet("/")]
        public IActionResult Index(string message)
        {
            return View((object)message);
        }

        [HttpPost("/matrix")]
        public IActionResult CheckTheMatrix(string inputMatrix)
        {
            return View("Index", matrixService.AddNewMatrix(inputMatrix));
        }

        [HttpGet("/matrices")]
        public IActionResult GoodMatrices(string inputMatrix)
        {
            return Json(matrixService.GetMatrices());
        }
    }
}