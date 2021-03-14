using System;
using State.Pattern;

namespace State
{
    public class ControlTwenty
    {
        public void Run()
        {
            TV tv = new TV(new StateOff());
            tv.TurnOff();
            tv.TurnOn();
            tv.TurnOn();
            tv.TurnOff();
        }
    }
}
