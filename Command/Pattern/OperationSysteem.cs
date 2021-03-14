using System;
using System.Collections.Generic;

namespace Command.Pattern
{
    public class OperationSysteem
    {
        private List<Command> _commands = new List<Command>();
        private int state = 0;
        private Calculator _calculator;

        public OperationSysteem()
        {
            _calculator = new Calculator();
        }

        public void AddCommand(Command newCommand)
        {
            newCommand.SetCalculator(_calculator);
            _commands.Add(newCommand);
        }

        public void ExecuteCommands()
        {
            for (; state < _commands.Count; state++)
            {
                _commands[state].Execute();
                state++;
            }
        }

        public void Undo(int level)
        {
            int totalTimes = 0;

            for (; state > 0; state--)
            {
                totalTimes++;
                _commands[state - 1].Undo();

                if (totalTimes == level)
                {
                    break;
                }
            }
        }

        public void Redo(int level)
        {
            int totalTimes = 0;

            for (; state < _commands.Count; state++)
            {
                totalTimes++;
                _commands[state - 1].Execute();

                if (totalTimes == level)
                {
                    break;
                }
            }
        }

        public void PrintResult()
        {
            Console.WriteLine($"The result of the calculator is: {_calculator.Result}");
        }
    }
}
