using Lekcja_2_ASP_NET_WSEI_2023.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lekcja_2_ASP_NET_WSEI_2023.Controllers
{
    public class BirthController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Birth model)
        {
            if (model.IsValid())
            {
                int age = model.CalculateAge();
                ViewBag.Message = $"Cześć {model.Name}, masz {age} lat(a).";
            }
            else
            {
                ViewBag.Message = "Błąd w formularzu. Sprawdź wprowadzone dane.";
            }

            return View();
        }
    }
}
