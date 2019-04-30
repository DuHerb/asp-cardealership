using System.Collections.Generic;
using System;
using CarDealership.Models;

namespace CarDealership.Models
{

  public class Car
  {
    private string MakeModel;
    private int Price;
    private int Miles;
    private string Note;
    private static List<Car> _carLot = new List<Car> {};

    public Car(string makeModel, int price, int miles, string note)
    {
      MakeModel = makeModel;
      Price = price;
      Miles = miles;
      Note = note;
      _carLot.Add(this);
    }

    public string GetNote()
    {
      return Note;
    }

    public string GetMakeModel()
    {
      return MakeModel;
    }

    public int GetPrice()
    {
      return Price;
    }

    public int GetMiles()
    {
      return Miles;
    }

    public void SetPrice(int newPrice)
    {
      Price = newPrice;
    }

    public void SetNote(string newNote)
    {
      Note = newNote;
    }

    public bool WorthBuying(int maxPrice, int maxMileage)
    {
      return (Price < maxPrice && Miles <= maxMileage);
    }

    public void DisplayInfo()
    {
    Console.WriteLine("______________________");
    Console.WriteLine(MakeModel);
    Console.WriteLine(Miles + " miles");
    Console.WriteLine("$" + Price);
    Console.WriteLine(Note);
    }

    public static List<Car> GetCarLot()
    {
      return _carLot;
    }

    public static void ClearAll()
{
    _carLot.Clear();
}

  }
}
