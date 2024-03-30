using Microsoft.AspNetCore.Mvc;

namespace Task2.Controllers
{
    public class CalcController : Controller
    {
        public IActionResult Add(double x, double y)
        {
            var res = x + y;
            return View(res);
        }
        public IActionResult Sub(double x, double y)
        {
            var res = x - y;
            return View(res);
        }
        public IActionResult Mul(double x, double y)
        {
                var res = x * y;
                return View(res);
        }
        public IActionResult Div(double x, double y)
        {
            if (y == 0.0)
            {
                return View("∞" as object);
            }
            var res = x / y;
            return View(res);
        }
    }
}
