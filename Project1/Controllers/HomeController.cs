using Microsoft.AspNetCore.Mvc;
using Project1.Models;

namespace Project1.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.FV = 0; return View();
        }

        [HttpPost]
        public IActionResult Display(VehicleSaleModel model)
        {
            if (ModelState.IsValid)
            {
                ViewBag.FV = model.VehicleSaleCal();
            }
            else
            {
                ViewBag.FV = 0;
            }
            return View(model);
        }
    }
}
