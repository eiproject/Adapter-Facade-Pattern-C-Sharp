using System;
using System.Collections.Generic;
using System.Text;

namespace FacadePattern {
  class Run {
    internal Run() { }
    internal void Start() {
      Milk milk = new Milk();
      Bread bread = new Bread();
      Coffee coffee = new Coffee();
      Omelete omelete = new Omelete();
      Rice rice = new Rice();
      Soup soup = new Soup();

      IFoodMenus Breakfast = new FoodForBreakfast(milk, bread);
      Breakfast.Prepare();

      IFoodMenus Lunch = new FoodForLunch(rice, omelete);
      Lunch.Prepare();

      IFoodMenus Dinner = new FoodForDinner(coffee, rice, soup);
      Dinner.Prepare();
    }
  }
}
