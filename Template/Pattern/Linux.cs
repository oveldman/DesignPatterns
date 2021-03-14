using System;
namespace Template.Pattern
{
    public class Linux : Computer
    {
        public override void Bootup()
        {
            Console.WriteLine("Fedora is bootup now.");
        }

        public override void ExecuteCommand()
        {
            Console.WriteLine("The command is running now");
        }

        public override void StartProgram()
        {
            Console.WriteLine("Open terminal now.");
        }
    }
}
