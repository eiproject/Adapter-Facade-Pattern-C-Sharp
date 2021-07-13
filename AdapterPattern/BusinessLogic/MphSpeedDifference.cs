using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern {
  class MphSpeedDifference {
    private float _speedDifference;
    private float _speed1;
    private float _speed2;
    private string _faster;
    internal MphSpeedDifference(ICar first, ICar second) {
      _speed1 = first.GetSpeed();
      _speed2 = second.GetSpeed();

      if (_speed1 >= _speed2) {
        _speedDifference = _speed1 - _speed2;
        _faster = first.GetName();
      }
      else {
        _speedDifference = _speed2 - _speed1;
        _faster = second.GetName();
      }
    }
    internal float GetDifference() {
      return _speedDifference;
    }
    internal void CheckDifference() {
      Console.WriteLine($"{ _faster } faster. Speed Difference is { _speedDifference} Mph");
    }
  }
}
