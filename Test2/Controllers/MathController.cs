using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MathOperationApp.Models;
using MathLibrary;


namespace MathCon.Controllers
{
    public class MathController : Controller
    {
        [HttpGet]
        public IActionResult DoCalculation()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ShowCalculationResults()
        {
            MathController model = new MathController();
            return View();
        }


    }
}

