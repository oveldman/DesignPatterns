using System;

namespace DesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creational Patterns
            Console.WriteLine("\n");
            Console.WriteLine("Creational Patterns");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("\n");

            CreationalPatterns.Start();

            // Structural Patterns
            Console.WriteLine("\n");
            Console.WriteLine("Structural Patterns");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("\n");

            StructuralPatterns.Start();

            // Behavioral Patterns
            Console.WriteLine("\n");
            Console.WriteLine("Behavioral Patterns");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("\n");

            BehavioralPatterns.Start();
        }
    }
}
