using System;
namespace Visitor.Pattern
{
    public class Warrior : Character
    {
        public Warrior()
        {
            Name = "Warrior";
            Level = 5;
            ArmorProtecting = 10;
        }
    }
}
