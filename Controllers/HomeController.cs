using Calculator.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Runtime.ExceptionServices;

namespace Calculator.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Calculator(Calc calculator)
        {
            ViewBag.output = "Insert data";

            switch (calculator.sign)
            {
                case "+":
                    ViewBag.output = $"Output: {calculator.firstNumber + calculator.secondNumber}";
                    break;
                case "-":
                    ViewBag.output = $"Output: {calculator.firstNumber - calculator.secondNumber}";
                    break;
                case "*":
                    ViewBag.output = $"Output: {calculator.firstNumber * calculator.secondNumber}";
                    break;
                case "/":
                    ViewBag.output = $"Output: {calculator.firstNumber / calculator.secondNumber}";
                    break;
                default:
                    ViewBag.output = $"Invalid sign";
                    break;
            }

            
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}