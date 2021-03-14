using System;
namespace State.Pattern
{
    public class StateOff : State
    {
        public StateOff()
        {
        }

        public override void TurnOff(TV tv)
        {
            Console.WriteLine("The device is already turned off");
        }

        public override void TurnOn(TV tv)
        {
            Console.WriteLine("The device is turning on now...");
            tv.State = new StateOn();
        }

        public override string ToString()
        {
            return "State is off";
        }
    }
}
