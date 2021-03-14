using System;
namespace Brigde.Pattern
{
    public class Laptop : IDevice
    {
        private IScreen _screen;

        public Laptop(IScreen screen)
        {
            _screen = screen;
        }

        public void ShowDisplay()
        {
            _screen.ShowType();
        }

        public void TurnOn()
        {
            Console.WriteLine("Laptop turns on");
        }
    }
}
