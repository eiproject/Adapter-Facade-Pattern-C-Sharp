using System;
using System.Collections.Generic;
using System.Text;

namespace FacadePattern {
  class Omelete {
    internal void TakeEgg() {
      Console.WriteLine("Taking egg...");
    }
    internal void Fry() {
      Console.WriteLine("Frying egg...");
    }
    internal void AddSalt() {
      Console.WriteLine("Adding salt...");
    }
    internal void PlaceOnThePlate() {
      Console.WriteLine("placing on plate...");
    }
  }
}
