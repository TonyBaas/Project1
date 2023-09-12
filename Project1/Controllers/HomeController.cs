using Microsoft.AspNetCore.Mvc;
using Project1.Models;

namespace Project1.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.VS = 0;
            ViewBag.VD = ""; 
             return View();
        }

        [HttpPost]
        public IActionResult Display(VehicleSaleModel model)
        {
            ViewBag.VS = model.VehicleSaleCal();
            ViewBag.VD = model.VehicleDisc();
            return View(model);
        }
    }
}
