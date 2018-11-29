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
        public IActionResult DoCalculation()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult ShowCalculationResults(MathOperation calculation)
        {
            switch (calculation.Operator)
            {
                case "Add":
                    calculation.Result = MathLibrary.MyMathRoutines.Add(calculation.LeftOperand, calculation.RightOperand);
                    break;
                case "Subtract":
                    calculation.Result = MathLibrary.MyMathRoutines.Subtract(calculation.LeftOperand, calculation.RightOperand);
                    break;
                case "Multiply":
                    calculation.Result = MathLibrary.MyMathRoutines.Multiply(calculation.LeftOperand, calculation.RightOperand);
                    break;
                case "Divide":
                    calculation.Result = MathLibrary.MyMathRoutines.Divide(calculation.LeftOperand, calculation.RightOperand);
                    break;
                    default:
                    break;
            }
            return View(calculation);
        }
    }
}