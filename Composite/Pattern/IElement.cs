using System;
namespace Composite.Pattern
{
    public interface IElement
    {
        public void Add(IElement element);
        public void Remove(IElement element);
        public void Draw(int indent);
    }
}
