using System;
using System.Collections.Generic;
using System.Text;

namespace FacadePattern {
  class Rice {
    internal void TakeRice() {
      Console.WriteLine("Taking Rice...");
    }
    internal void Wash() {
      Console.WriteLine("Wasihng...");
    }
    internal void Cook() {
      Console.WriteLine("Cooking, please wait...");
    }
    internal void Done() {
      Console.WriteLine("Rice ready...");
    }
  }
}
