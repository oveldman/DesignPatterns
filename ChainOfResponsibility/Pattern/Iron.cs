using System;
namespace ChainOfResponsibility.Pattern
{
    public class Iron : Block
    {
        public Iron()
        {
            _strength = 20;
        }

        public override void Protect(Bullit bullit)
        {
            if (_strength > bullit.Strength)
            {
                Console.WriteLine($"The bullit {bullit.Name} is bounched of by the iron!");
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
