using System;
namespace ChainOfResponsibility.Pattern
{
    public abstract class Block
    {
        protected Block _successor;
        protected int _strength;

        public void SetSuccessor(Block successor)
        {
            _successor = successor;
        }

        public abstract void Protect(Bullit bullit);
    }
}
