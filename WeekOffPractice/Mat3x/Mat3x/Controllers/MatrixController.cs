using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mat3x.Models;
using Mat3x.Service;
using Microsoft.AspNetCore.Mvc;

namespace Mat3x.Controllers
{
    public class MatrixController : Controller
    {
        public MatrixController(MatrixService matrixService)
        {
            this.matrixService = matrixService;
        }

        private MatrixService matrixService { get; set; }

        [HttpGet("/")]
        public IActionResult Index(string message)
        {
            return View( (object)message );
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