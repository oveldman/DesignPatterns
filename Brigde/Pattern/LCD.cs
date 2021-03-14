using System;
namespace Brigde.Pattern
{
    public class LCD : IScreen
    {
        public LCD()
        {
        }

        public void ShowType()
        {
            Console.WriteLine("This device has LCD screen");
        }
    }
}
