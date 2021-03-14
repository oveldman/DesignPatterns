using System;
namespace Iterator.Pattern
{
    public interface Aggregate
    {
        public Iterator CreateIterator();
    }
}
