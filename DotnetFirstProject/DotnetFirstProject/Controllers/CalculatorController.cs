using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotnetFirstProject.Controllers
{
    public class CalculatorController : Controller
    {   
        public string Add(int num1, int num2)
        {
            int result = num1 + num2;
            return "Addition = "+ result;
        }

        public string Sub(int num1, int num2)
        {
            int result = num1 - num2;
            return "Subtraction = " + result;
        }

        public string Mul(int num1, int num2)
        {
            int result = num1 * num2;

            return "Multiplication = " + result;
        }

        public string Div(int num1, int num2)
        {
            int result = num1 / num2;
            return "Division = " + result;
        }
    }
}
