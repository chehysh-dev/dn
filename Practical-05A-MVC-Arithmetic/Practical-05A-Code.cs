using arithmeticmvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace arithmeticmvc.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Calculator calc)
        {
            switch (calc.operation)
            {
                case "+":
                    calc.Result = calc.Number1 + calc.Number2;
                    break;

                case "-":
                    calc.Result = calc.Number1 - calc.Number2;
                    break;

                case "*":
                    calc.Result = calc.Number1 * calc.Number2;
                    break;

                case "/":
                    if (calc.Number2 != 0)
                    {
                        calc.Result = calc.Number1 / calc.Number2;
                    }
                    break;
            }

            return View(calc);
        }
    }
}
