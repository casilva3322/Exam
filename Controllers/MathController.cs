using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MidtermExam.Models;
using MathLibrary;



namespace MidtermExam.Controllers
{
    public class MathController: Controller
    {   
        [HttpGet]
        public IActionResult DoCalculation(decimal left, decimal right, decimal type)
        {
	    ViewData["Left"] = left;
        ViewData["Right"] = right;
        ViewData["Type"] = type;// How will I covert the methods add..into 1 method????
        ViewData["Get Result"] = $"{left} {type} {right} is: {MyMathRoutines.Add(left, right)}";
	    return View();
        }

        

        [HttpGet]
        public IActionResult ShowCalculationResults()
        {
                return View();
        }

    }
}