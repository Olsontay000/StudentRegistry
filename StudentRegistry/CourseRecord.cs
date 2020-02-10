using System;
using System.Collections.Generic;
using System.Text;

namespace StudentRegistry
{
    public class CourseRecord : IEquatable<CourseRecord>
    {
        public Course Course;

        public Grade Grade;

        public CourseRecord(Course course, Grade grade)
        {
            Course = course;
            Grade = grade;
        }

        public bool Equals(CourseRecord other)
        {
            return other.Course == Course;
        }

    }
}
