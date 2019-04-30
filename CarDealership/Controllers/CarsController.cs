
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
    public ActionResult Create(string makeModel, string price, string miles, string note)
    {
      Car myCar = new Car(makeModel, price, miles, note);
      return RedirectToAction("Index");
    }

    [HttpGet("/cars/search")]
    public ActionResult SearchForm()
    {
      return View();
    }

    [HttpPost("/cars/options")]
    public ActionResult Search(string findModel)
    {
      List<Car> searchResults = Car.SearchForModel(findModel);
      return View(searchResults);
    }
  }
}
