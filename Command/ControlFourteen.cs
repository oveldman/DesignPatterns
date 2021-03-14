
using Command.Pattern;

namespace Command
{
    public class ControlFourteen
    {
        public void Run()
        {
            OperationSysteem operationSysteem = new OperationSysteem();

            operationSysteem.AddCommand(new PlusCommand());
            operationSysteem.AddCommand(new PlusCommand());
            operationSysteem.AddCommand(new PlusCommand());
            operationSysteem.AddCommand(new MinCommand());
            operationSysteem.ExecuteCommands();
            operationSysteem.PrintResult();
            operationSysteem.Undo(2);
            operationSysteem.PrintResult();
            operationSysteem.Redo(1);
            operationSysteem.PrintResult();
        }
    }
}
