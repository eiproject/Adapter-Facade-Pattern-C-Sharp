using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern {
  interface ICar {
    void CheckSpeed();
    float GetSpeed();
    string GetName();
  }
}
