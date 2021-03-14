using System;
using Adapter.Pattern;

namespace Adapter
{
    public class ControlSix
    {
        public void Run()
        {
            TemperatureManager celsiusManager = new CelsiusManager();
            int celsius = celsiusManager.Calculate(300);

            Console.WriteLine($"300 kelvin = {celsius} celsius");
        }
    }
}
