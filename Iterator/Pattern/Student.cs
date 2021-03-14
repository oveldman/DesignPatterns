using System;
using System.Collections.Generic;

namespace Iterator.Pattern
{
    public class Student
    {
        public string Name { get; private set; }
        public bool IsGoodStudent { get; private set; }

        public Student()
        {
            List<string> RandomName = new List<string>
            {
                "Kees",
                "Piet",
                "Oscar"
            };

            List<string> RandomLastName = new List<string>
            {
                "Janssen",
                "Dekker",
                "Wit"
            };

            Random random = new Random();
            int first = random.Next(3);
            int last = random.Next(3);
            int good = random.Next(2);

            Name = RandomName[first];
            Name += " " + RandomLastName[last];
            IsGoodStudent = good == 1;
        }

        public void Shout()
        {
            Console.WriteLine(Name + " is a good student: " + IsGoodStudent);
        }
    }
}
