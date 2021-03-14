using System;
namespace Command.Pattern
{
    public class MinCommand : Command
    {
        public MinCommand()
        {
        }

        public override void Execute()
        {
            _calculator.Result--;
        }

        public override void Undo()
        {
            _calculator.Result++;
        }
    }
}
