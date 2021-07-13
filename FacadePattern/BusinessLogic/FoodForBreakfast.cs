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
      _milk.Make();
      _bread.Make();
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
