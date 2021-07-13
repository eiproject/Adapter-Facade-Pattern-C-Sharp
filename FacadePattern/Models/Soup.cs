using System;
using System.Collections.Generic;
using System.Text;

namespace FacadePattern {
  class Soup {
    internal void TakeVegetable() {
      Console.WriteLine("Taking vegetable...");
    }
    internal void Wash() {
      Console.WriteLine("Washing...");
    }
    internal void Boil() {
      Console.WriteLine("Boiling...");
    }
    internal void AddFlavor() {
      Console.WriteLine("Adding flavor...");
    }
    internal void PourToBowl() {
      Console.WriteLine("Pouring to bowl...");
    }
  }
}
