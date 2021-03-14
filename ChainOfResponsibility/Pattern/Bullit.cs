using System;
namespace ChainOfResponsibility.Pattern
{
    public class Bullit
    {
        public string Name { get; private set; }
        public int Strength { get; private set; }

        public Bullit(int strength, string name)
        {
            Name = name;
            Strength = strength;
        }
    }
}
