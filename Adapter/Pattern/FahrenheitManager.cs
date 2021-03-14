using System;
namespace Adapter.Pattern
{
    public class FahrenheitManager
    {
        public FahrenheitManager()
        {
        }

        public double Calculate(double kelvin)
        {
            double celsius = kelvin - 273.15;

            return celsius * 1.8 + 32;
        }
    }
}
