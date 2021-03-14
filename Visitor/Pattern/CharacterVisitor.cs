using System;
namespace Visitor.Pattern
{
    public class CharacterVisitor : IVisitor
    {

        public void Improve(Character character)
        {
            Console.WriteLine(character.Name + " current level is: " + character.Level);

            character.Level += 1;

            Console.WriteLine(character.Name + " level after the improvement " + character.Level);
        }
    }
}
