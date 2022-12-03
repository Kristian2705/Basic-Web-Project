using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using ParkingSystem.Data;
using ParkingSystem.Data.Models;
using System.Linq;

namespace ParkingSystem.Controllers
{
    public class CarController
    {
        [HttpPost]
        public IActionResult AddCar(Car car)
        {
            DataAccess.Cars.Add(car);
            var res = new RedirectResult("/");
            return res;
        }

        [HttpPost]
        public IActionResult DeleteCar(string plateNumber) 
        {
            var carToRemove = DataAccess.Cars.FirstOrDefault(x => x.PlateNumber == plateNumber);
            DataAccess.Cars.Remove(carToRemove);
            var res = new RedirectResult("/");
            return res;
        }
    }
}
