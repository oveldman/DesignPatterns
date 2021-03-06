using System;
namespace ChainOfResponsibility.Pattern
{
    public class Water : Block
    {
        public Water()
        {
            _strength = 5;
        }

        public override void Protect(Bullit bullit)
        {
            if (_strength > bullit.Strength)
            {
                Console.WriteLine($"The bullit {bullit.Name} is protected by the water!");
            }
            else if (_successor != null)
            {
                _successor.Protect(bullit);
            }
            else
            {
                Console.WriteLine($"No block could protect you from {bullit.Name}!");
            }
        }
    }
}
