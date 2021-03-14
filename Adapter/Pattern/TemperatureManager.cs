using System;
namespace Adapter.Pattern
{
    public class TemperatureManager
    {
        public virtual int Calculate(int kelvin)
        {
            return 0;
        }
    }
}
