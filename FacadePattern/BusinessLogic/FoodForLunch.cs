using System;
using System.Collections.Generic;
using System.Text;

namespace FacadePattern {
  class FoodForLunch : IFoodMenus {
    Rice _rice;
    Omelete _omelete;
    string _name = "Lunch";
    internal FoodForLunch(Rice rice, Omelete omelete) {
      Status();
      _rice = rice;
      _omelete = omelete;
    }
    void IFoodMenus.Prepare() {
      _rice.Make();
      _omelete.Make();
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
