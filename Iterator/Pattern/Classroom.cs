using System;
using System.Collections.Generic;

namespace Iterator.Pattern
{
    public class Classroom : Aggregate
    {
        private List<Student> _students = new List<Student>(); 

        public Iterator CreateIterator()
        {
            return new CourseManager(this);
        }

        public int Count
        {
            get { return _students.Count; }
        }

        public Student this[int index]
        {
            get {
                return _students[index];
            }
            set
            {
                _students.Insert(index, value);
            }
        }
    }
}
