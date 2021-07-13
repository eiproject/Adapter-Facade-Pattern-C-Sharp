using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern {
  class CarAdapter : ICar {
    private float _mphSpeed;
    private ICar _kmhCar;
    internal CarAdapter(ICar kmhCar) {
      float kmhSpeed = kmhCar.GetSpeed();
      _mphSpeed = kmhSpeed / 1.60934F;
    }

    float ICar.GetSpeed() {
      return _mphSpeed;
    }

    void ICar.CheckSpeed() {
      _kmhCar.CheckSpeed();
    }

    string ICar.GetName() {
      return _kmhCar.GetName();
    }
  }
}
