using System;
namespace Brigde.Pattern
{
    public class Macbook : IDevice
    {
        private IScreen _screen;

        public Macbook(IScreen screen)
        {
            _screen = screen;
        }

        public void ShowDisplay()
        {
            _screen.ShowType();
        }

        public void TurnOn()
        {
            Console.WriteLine("Macbook turns on!");
        }
    }
}
