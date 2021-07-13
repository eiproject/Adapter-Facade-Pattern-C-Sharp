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
      _rice.TakeRice();
      _rice.Wash();
      _rice.Cook();
      _rice.Done();
      _omelete.TakeEgg();
      _omelete.Fry();
      _omelete.AddSalt();
      _omelete.PlaceOnThePlate();
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
