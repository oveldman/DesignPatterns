using System;
namespace State.Pattern
{
    public class TV
    {
        private State _state;

        public TV(State state)
        {
            _state = state;
        }

        public State State
        {
            get
            {
                return _state;
            }
            set
            {
                _state = value;
                Console.WriteLine(_state.ToString());
            }
        }

        public void TurnOn()
        {
            _state.TurnOn(this);
        }

        public void TurnOff()
        {
            _state.TurnOff(this);
        }
    }
}
