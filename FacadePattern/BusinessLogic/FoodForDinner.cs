using System;
using System.Collections.Generic;
using System.Text;

namespace FacadePattern {
  class FoodForDinner : IFoodMenus {
    Coffee _coffee;
    Rice _rice;
    Soup _soup;
    string _name = "Dinner";
    internal FoodForDinner(Coffee coffee, Rice rice, Soup soup) {
      Status();
      _coffee = coffee;
      _rice = rice;
      _soup = soup;
    }
    void IFoodMenus.Prepare() {
      _rice.TakeRice();
      _rice.Wash();
      _rice.Cook();
      _rice.Done();
      _coffee.TakeCoffee();
      _coffee.TakeSugar();
      _coffee.PourTheWater();
      _coffee.Stir();
      _coffee.PlaceOnTable();
      _soup.TakeVegetable();
      _soup.Wash();
      _soup.Boil();
      _soup.AddFlavor();
      _soup.PourToBowl();
      Done();
    }
    void Status() {
      Console.WriteLine($"Making { _name }");
    }
    void Done() {
      Console.WriteLine($"{ _name } Done.\n");
    }
  }
}
