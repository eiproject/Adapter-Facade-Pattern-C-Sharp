using System;
using System.Collections.Generic;
using System.Text;

namespace FacadePattern {
  class FoodForBreakfast : IFoodMenus {
    Milk _milk;
    Bread _bread;
    string _name = "Breakfast";

    internal FoodForBreakfast(Milk milk, Bread bread) {
      Status();
      _milk = milk;
      _bread = bread;
    }

    void IFoodMenus.Prepare() {
      _milk.TakeMilk();
      _milk.TakeMug();
      _milk.PourToGlass();
      _bread.TakeBread();
      _bread.PutJam();
      _bread.Roast();
      _bread.PlaceOnPlate();
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
