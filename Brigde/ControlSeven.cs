using System;
using Brigde.Pattern;

namespace Brigde
{
    public class ControlSeven
    {
        public void Run()
        {
            IScreen lcdScreen = new LCD();
            IScreen oledScreen = new OLED();

            IDevice macbookLcd = new Macbook(lcdScreen);
            IDevice macbookOled = new Macbook(oledScreen);
            IDevice laptopLcd = new Laptop(lcdScreen);
            IDevice laptopOled = new Laptop(oledScreen);

            macbookLcd.TurnOn();
            macbookLcd.ShowDisplay();
            Console.WriteLine("------------------------------------");
            macbookOled.TurnOn();
            macbookOled.ShowDisplay();
            Console.WriteLine("------------------------------------");
            laptopLcd.TurnOn();
            laptopLcd.ShowDisplay();
            Console.WriteLine("------------------------------------");
            laptopOled.TurnOn();
            laptopOled.ShowDisplay();
        }
    }
}
