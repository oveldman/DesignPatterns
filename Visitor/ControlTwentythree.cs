using System;
using Visitor.Pattern;

namespace Visitor
{
    public class ControlTwentythree
    {
        public void Run()
        {
            World world = new World();
            world.Add(new Archer());
            world.Add(new Warrior());

            world.Improve(new CharacterVisitor());
            world.Improve(new ArmorVisitor());
        }
    }
}
