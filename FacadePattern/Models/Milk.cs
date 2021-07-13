using System;
using System.Collections.Generic;
using System.Text;

namespace FacadePattern {
  class Milk  {
    internal void TakeMilk() {
      Console.WriteLine("Taking milk...");
    }
    internal void TakeMug() {
      Console.WriteLine("Taking mug...");
    }
    internal void PourToGlass() {
      Console.WriteLine("Pouring milk...");
    }
  }
}
