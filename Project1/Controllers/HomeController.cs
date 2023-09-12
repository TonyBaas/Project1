using Microsoft.AspNetCore.Mvc;
using Project1.Models;

namespace Project1.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Display(VehicleSaleModel model)
        {
           if (ModelState.IsValid)
            {
                ViewBag.VS = model.VehicleSaleCal();
            }
            else
            {
                ViewBag.VS = 0;
            }

            return View(model);
        }
    }
}
