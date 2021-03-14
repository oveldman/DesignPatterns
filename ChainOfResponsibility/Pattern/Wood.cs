using System;
namespace ChainOfResponsibility.Pattern
{
    public class Wood : Block
    {
        public Wood()
        {
            _strength = 10;
        }

        public override void Protect(Bullit bullit)
        {
            if (_strength > bullit.Strength)
            {
                Console.WriteLine($"The bullit {bullit.Name} is block by the woods!");
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
