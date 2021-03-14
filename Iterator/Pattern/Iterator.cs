using System;
namespace Iterator.Pattern
{
    public abstract class Iterator
    {
        protected Classroom _aggregate;

        public Iterator(Classroom aggregate)
        {
            _aggregate = aggregate;
        }

        public abstract Student First();

        public abstract Student Next();

        public abstract bool IsDone();

        public abstract Student CurrentItem();
    }
}
