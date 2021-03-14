using System;
namespace Adapter.Pattern
{
    public class CelsiusManager : TemperatureManager
    {
        private FahrenheitManager _fahrenheitManager;

        public CelsiusManager()
        {
            _fahrenheitManager = new FahrenheitManager();
        }

        public override int Calculate(int kelvin)
        {
            double fahrenheit = _fahrenheitManager.Calculate(kelvin);

            return (int)((fahrenheit - 32) / 1.8);
        }
    }
}
