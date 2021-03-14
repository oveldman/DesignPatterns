using System;
namespace Prototype.Pattern
{
    public class Location : LocationPrototype
    {
        private double _longitude;
        private double _latitude;
        private string _bestAttraction;

        public Location(double longitude, double latitude, string bestAttraction)
        {
            _longitude = longitude;
            _latitude = latitude;
            _bestAttraction = bestAttraction;
        }

        public override LocationPrototype Clone()
        {
            Console.WriteLine(
                "Cloning locationn: long {0}, lat {1}, best {2}",
                    _longitude, _latitude, _bestAttraction);



            return this.MemberwiseClone() as LocationPrototype;
        }
    }
}
