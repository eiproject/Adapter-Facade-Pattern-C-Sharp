using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern {
  class AmericanCar : ICar{
    private float _speed;
    private string _name;
    internal AmericanCar(float speed, string name) {
      _speed = speed;
      _name = name;
    }
    void ICar.CheckSpeed() {
      Console.WriteLine($"This US Car, {_name}, speed is: { _speed } Mph");
    }
    float ICar.GetSpeed() {
      return _speed;
    }
    string ICar.GetName() {
      return _name;
    }
  }
}
