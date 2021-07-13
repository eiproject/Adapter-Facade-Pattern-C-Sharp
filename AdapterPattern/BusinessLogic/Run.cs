using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern {
  class Run {
    internal Run() {
    }
    internal void Start() {
      ICar Tesla = new AmericanCar(100.5F, "Tesla");
      ICar Esemka = new IndonesianCar(125.3F, "Esemka");

      Tesla.CheckSpeed();
      Esemka.CheckSpeed();

      CarAdapter AdaptedEsemka = new CarAdapter(Esemka);
      MphSpeedDifference SpeedDiff = new MphSpeedDifference(Tesla, AdaptedEsemka);
      SpeedDiff.CheckDifference();
    }
  }
}
