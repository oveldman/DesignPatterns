using System;
namespace Command.Pattern
{
    public class PlusCommand : Command
    {
        public PlusCommand()
        {
        }

        public override void Execute()
        {
            _calculator.Result++;
        }

        public override void Undo()
        {
            _calculator.Result--;
        }
    }
}
