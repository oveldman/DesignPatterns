using System;
namespace Decorator.Pattern
{
    public class CruiseShip : Decorator
    {
        public CruiseShip()
        {
        }

        public override void Sail()
        {
            base.Sail();

            Console.WriteLine("Speed up!");
        }
    }
}
