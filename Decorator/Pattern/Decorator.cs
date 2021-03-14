using System;
namespace Decorator.Pattern
{
    public class Decorator : Ship
    {
        private Ship _ship;
        public Decorator()
        {
        }

        public void SetShip(Ship ship)
        {
            _ship = ship;
        }

        public override void Sail()
        {
            _ship?.Sail();
        }
    }
}
