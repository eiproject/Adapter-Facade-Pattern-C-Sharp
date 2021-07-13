using System;
using System.Collections.Generic;
using System.Text;

namespace FacadePattern {
  class Bread {

    internal void TakeBread() {
      Console.WriteLine("Take bread...");
    }
    internal void PutJam() {
      Console.WriteLine("Put jam...");
    }
    internal void Roast() {
      Console.WriteLine("Roasting...");
    }
    internal void PlaceOnPlate() {
      Console.WriteLine("Placing on plate...");
    }
  }
}
