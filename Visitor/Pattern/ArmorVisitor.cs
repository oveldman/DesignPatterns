using System;
namespace Visitor.Pattern
{
    public class ArmorVisitor : IVisitor
    {
        public void Improve(Character character)
        {
            Console.WriteLine(character.Name + " current armor level is: " + character.ArmorProtecting);

            character.ArmorProtecting += 3;

            Console.WriteLine(character.Name + " armor level after the improvement " + character.ArmorProtecting);
        }
    }
}
