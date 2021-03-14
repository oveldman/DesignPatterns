using System;
using Facade.Pattern;

namespace Facade
{
    public class ControlTen
    {
        public void Run()
        {
            House house = new House();
            house.GoInside();
        }
    }
}
