using System;
namespace Brigde.Pattern
{
    public class OLED : IScreen
    {
        public OLED()
        {
        }

        public void ShowType()
        {
            Console.WriteLine("This device has OLED screen");
        }
    }
}
