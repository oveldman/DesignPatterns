using System;
namespace FlyWeight.Pattern
{
    public class Ship
    {
        public string _name { get; private set; }
        public int _length { get; private set; }
        public int _width { get; private set; }
        public int _weight { get; private set; }

        public Ship(string name, int length, int width, int weight)
        {
            _name = name;
            _length = length;
            _width = width;
            _weight = weight;
        }
    }
}
