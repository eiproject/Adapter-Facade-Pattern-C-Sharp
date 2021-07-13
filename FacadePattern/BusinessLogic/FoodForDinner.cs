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
      _rice.Make();
      _coffee.Make();
      _soup.Make();
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
