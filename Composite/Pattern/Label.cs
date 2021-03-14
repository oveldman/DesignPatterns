using System;
namespace Composite.Pattern
{
    public class Label : IElement
    {
        private string _name;

        public Label(string name)
        {
            _name = $"L: {name}";
        }

        public void Add(IElement element)
        {
            Console.WriteLine("Cannot add to a Label");
        }

        public void Draw(int indent)
        {
            Console.WriteLine(new String('-', indent) + " " + _name);
        }

        public void Remove(IElement element)
        {
            Console.WriteLine("Cannot remove from a Label");
        }
    }
}
