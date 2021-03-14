using System;
namespace FlyWeight.Pattern
{
    public class CargoShip
    {
        private Ship _baseShip;
        private int _x;
        private int _y;

        public CargoShip(Ship baseShip)
        {
            _baseShip = baseShip;
        }

        public void SetSail()
        {
            _x += 2;
            _y += 4;
            Console.WriteLine($"{_baseShip._name} is moving to: x {_x} and y {_y} because of length is {_baseShip._length}");
        }
    }
}
