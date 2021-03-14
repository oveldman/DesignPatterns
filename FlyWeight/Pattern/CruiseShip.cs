using System;
namespace FlyWeight.Pattern
{
    public class CruiseShip
    {
        private Ship _baseShip;
        private int _x;
        private int _y;

        public CruiseShip(Ship baseShip)
        {
            _baseShip = baseShip;
        }

        public void SetSail()
        {
            _x += 5;
            _y += 10;
            Console.WriteLine($"{_baseShip._name} is moving to: x {_x} and y {_y} because of length is {_baseShip._length} and width is {_baseShip._width}!");
        }
    }
}
