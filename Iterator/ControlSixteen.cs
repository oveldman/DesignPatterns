using System;
using Iterator.Pattern;

namespace Iterator
{
    public class ControlSixteen
    {
        public void Run()
        {
            Classroom classroom = new Classroom();
            classroom[0] = new Student();
            classroom[1] = new Student();
            classroom[2] = new Student();
            classroom[3] = new Student();

            var courseManager =  classroom.CreateIterator();

            Student student = courseManager.First();

            while (student != null)
            {
                student.Shout();
                student = courseManager.Next();
            }
        }
    }
}
