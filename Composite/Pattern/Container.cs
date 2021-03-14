using System;
using System.Collections.Generic;

namespace Composite.Pattern
{
    public class Container : IElement
    {
        private List<IElement> _allElements;
        private string _name;

        public Container(string name)
        {
            _name = $"C: {name}";
            _allElements = new List<IElement>();
        }

        public void Add(IElement element)
        {
            _allElements.Add(element);
        }

        public void Draw(int indent)
        {
            Console.WriteLine(new String('-', indent) + "+ " + _name);

            foreach (IElement element in _allElements)
            {
                element.Draw(indent + 2);
            }
        }

        public void Remove(IElement element)
        {
            _allElements.Remove(element);
        }
    }
}
