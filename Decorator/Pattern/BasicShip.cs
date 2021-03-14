using System;
namespace Decorator.Pattern
{
    public class BasicShip : Ship
    {
        public BasicShip()
        {
        }

        public override void Sail()
        {
            Console.WriteLine("Sail normally!");
        }
    }
}
