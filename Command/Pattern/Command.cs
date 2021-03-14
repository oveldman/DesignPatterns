using System;
namespace Command.Pattern
{
    public abstract class Command
    {
        protected Calculator _calculator;

        public Command()
        {
        }

        public void SetCalculator(Calculator calculator)
        {
            _calculator = calculator;
        }

        public abstract void Execute(); 
        public abstract void Undo();
    }
}
