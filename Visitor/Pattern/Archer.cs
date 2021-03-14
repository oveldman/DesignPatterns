using System;
namespace Visitor.Pattern
{
    public class Archer : Character
    {
        public Archer()
        {
            Name = "Archer";
            Level = 2;
            ArmorProtecting = 4;
        }
    }
}
