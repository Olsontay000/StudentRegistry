using System;
using System.Collections.Generic;
using System.Text;

namespace StudentRegistry
{
    public class Course : IEquatable<Course>
    {
        public uint CourseNumber;

        public string Title;

        public uint CreditHours;

        public bool Equals(Course other)
        {
            return other.CourseNumber == CourseNumber;
        }
    }
}
