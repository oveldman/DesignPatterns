using System;
namespace State.Pattern
{
    public class StateOn : State
    {
        public override void TurnOff(TV tv)
        {
            Console.WriteLine("The device is turning off now...");
            tv.State = new StateOff();
        }

        public override void TurnOn(TV tv)
        {
            Console.WriteLine("The device is already turned on");
        }

        public override string ToString()
        {
            return "State is on";
        }
    }
}
