using System;
namespace Iterator.Pattern
{
    public class CourseManager : Iterator
    {
        private int _current = 0;

        public CourseManager(Classroom aggregate) : base(aggregate)
        {
        }

        public override Student CurrentItem()
        {
            return _aggregate[_current];
        }

        public override Student First()
        {
            return _aggregate[0];
        }

        public override bool IsDone()
        {
            return _current >= _aggregate.Count;
        }

        public override Student Next()
        {
            Student ret = null;

            if (_current < _aggregate.Count - 1)

            {

                ret = _aggregate[++_current];

            }

            return ret;
        }
    }
}
