using Microsoft.AspNetCore.Mvc;
//using Car.Models;
using CarModel = Car.Models.Car;
using System.Collections.Generic;
using System.Linq;
namespace Car.Controllers
{
    public class CarsController : Controller
    {

        private static List<CarModel> availableCars = new List<CarModel>()
        {
         new CarModel(1, "Alto", 3000),
        new CarModel(2, "Carolla", 6000),
        new CarModel(3, "Civic", 1800000)
        };

        private static List<CarModel> bookedCars = new List<CarModel>();
        [HttpGet]
        public IActionResult Index()
        {   
            return View(availableCars);
        }
        [HttpPost]
        public IActionResult Book (int id )
        {
            var car = availableCars.FirstOrDefault(c => c.id == id);
            if (car != null)
            {
                bookedCars.Add(car);

                availableCars.Remove(car);
                return RedirectToAction("Booked");

            }
            else 
                return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Booked()
        { return View(bookedCars); }
    }
}
