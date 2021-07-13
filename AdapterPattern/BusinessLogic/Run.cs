using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern {
  class Run {
    internal Run() {
    }
    internal void Start() {
      ICar Tesla = new AmericanCar(120.5F, "Tesla"); // speed in Mph
      ICar Esemka = new IndonesianCar(125.3F, "Esemka"); // speed in Kmh

      Tesla.CheckSpeed();
      Esemka.CheckSpeed();

      CarAdapter AdaptedEsemka = new CarAdapter(Esemka); // Turn Kmh to Mph
      MphSpeedDifference SpeedDiff = new MphSpeedDifference(Tesla, AdaptedEsemka);
      SpeedDiff.CheckDifference();
    }
  }
}
