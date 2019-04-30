using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using CarDealership.Models;

namespace CarDealership.Controllers
{
  public class CarsController : Controller
  {

    [HttpGet("/cars")]
    public ActionResult Index()
    {
      List<Car> allCars = Car.GetCarLot();
      return View(allCars);
    }

    [HttpGet("/cars/new")]
    public ActionResult CreateForm()
    {
      return View();
    }

    [HttpPost("/cars")]
      public ActionResult Create(string makeModel, int price, int miles, string note)
      {
        Car myCar = new Car( makeModel,  price,  miles,  note);
        return RedirectToAction("Index");
      }
  }
}
