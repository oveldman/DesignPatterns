using System;
namespace Decorator.Pattern
{
    public class AdvancedShip : Decorator
    {
        public AdvancedShip()
        {
        }

        public override void Sail()
        {
            base.Sail();
            Console.WriteLine("Speed up even more!");
        }
    }
}
