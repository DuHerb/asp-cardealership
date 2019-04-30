using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using CarDealership.Models;

namespace CarDealership.Tests
{
  [TestClass]
  public class CarTest : IDisposable
  {

    public void Dispose()
    {
        Car.ClearAll();
    }

    // [TestMethod]
    // public void ItemConstructor_CreatesInstanceOfItem_Item()
    // {
    //     Item newItem = new Item("test");
    //     Assert.AreEqual(typeof(Item), newItem.GetType());
    // }
    //
    // [TestMethod]
    // public void GetDescription_ReturnsDescription_String()
    // {
    //     string description = "Walk the dog.";
    //     Item newItem = new Item(description);
    //     string result = newItem.GetDescription();
    //     Assert.AreEqual(description, result);
    // }
    //
    // [TestMethod]
    // public void SetDescription_SetDescription_String()
    // {
    //   string description = "Walk the dog.";
    //   Item newItem = new Item(description);
    //   string updatedDescription = "Do the dishes";
    //   newItem.SetDescription(updatedDescription);
    //   string result = newItem.GetDescription();
    //   Assert.AreEqual(updatedDescription, result);
    // }

    [TestMethod]
    public void GetAll_ReturnsEmptyList_CarList()
    {
        List<Car> newCar = new List<Car> {};
        List<Car> result = Car.GetCarLot();

        CollectionAssert.AreEqual(newCar, result);
    }

    [TestMethod]
    public void GetAll_ReturnsItems_CarList()
    {
    string model1 = "Ford";
    int price1 = 10000;
    int miles1 = 2000;
    string note1= "Lemon";

    string model2 = "Chevy";
    int price2 = 120000;
    int miles2 = 2300;
    string note2 = "Almost New";

    Car newCar1 = new Car (model1, price1, miles1, note1);
    Car newCar2 = new Car (model2, price2, miles2, note2);
    List<Car> newList = new List<Car> { newCar1, newCar2 };
    List<Car> result = Car.GetCarLot();

    CollectionAssert.AreEqual(newList, result);
    }
  }
}
