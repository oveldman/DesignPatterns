using System;
namespace Template.Pattern
{
    public abstract class Computer
    {
        public abstract void Bootup();
        public abstract void StartProgram();
        public abstract void ExecuteCommand();

        public void RunCommand(string command)
        {
            Bootup();
            StartProgram();
            ExecuteCommand();
            Console.WriteLine("Command '" + command + "' runs succesfully.");
        }
    }
}
