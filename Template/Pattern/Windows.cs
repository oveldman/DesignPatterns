using System;
namespace Template.Pattern
{
    public class Windows : Computer
    {
        public override void Bootup()
        {
            Console.WriteLine("Start windows 10...");
        }

        public override void ExecuteCommand()
        {
            Console.WriteLine("Execute command very fast!");
        }

        public override void StartProgram()
        {
            Console.WriteLine("Open up CMD");
        }
    }
}
