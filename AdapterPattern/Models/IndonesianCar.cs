using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern {
  class IndonesianCar : ICar {
    private float _speed;
    private string _name;
    internal IndonesianCar(float speed, string name) {
      _speed = speed;
      _name = name;
    }
    void ICar.CheckSpeed() {
      Console.WriteLine($"This Indonesian Car, {_name}, speed is: { _speed } Kmph");
    }

    float ICar.GetSpeed() {
      return _speed;
    }
    string ICar.GetName() {
      return _name;
    }
  }
}
