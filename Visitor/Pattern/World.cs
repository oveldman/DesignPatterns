using System;
using System.Collections.Generic;

namespace Visitor.Pattern
{
    public class World
    {
        private List<Character> _characters = new List<Character>();

        public void Add(Character character)
        {
            _characters.Add(character);
        }

        public void Remove(Character character)
        {
            _characters.Remove(character);
        }

        public void Improve(IVisitor visitor)
        {
            foreach (var character in _characters)
            {
                visitor.Improve(character);
            }
        }
    }
}
