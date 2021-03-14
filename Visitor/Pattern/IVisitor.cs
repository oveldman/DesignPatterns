using System;
namespace Visitor.Pattern
{
    public interface IVisitor
    {
        void Improve(Character character);
    }
}
