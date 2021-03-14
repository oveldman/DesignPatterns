using System;
namespace State.Pattern
{
    public abstract class State
    {
        public abstract void TurnOn(TV tv);
        public abstract void TurnOff(TV tv);
    }
}
