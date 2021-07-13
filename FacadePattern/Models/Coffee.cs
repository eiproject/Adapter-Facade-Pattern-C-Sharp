using System;
using System.Collections.Generic;
using System.Text;

namespace FacadePattern {
  class Coffee{
    internal void TakeCoffee() {
      Console.WriteLine("Take Coffee...");
    }
    internal void TakeSugar() {
      Console.WriteLine("Take sugar...");
    }
    internal void PourTheWater() {
      Console.WriteLine("Pouring water...");
    }
    internal void Stir() {
      Console.WriteLine("Stir...");
    }
    internal void PlaceOnTable() {
      Console.WriteLine("Place on table...");
    }
  }
}
