using System;
using System.Collections.Generic;
using System.Linq;
namespace School.Utils
{
    public class Constants
    {
        public const int MinimumIdNumber = 10000;
        public const int MaximumIdNumber = 99999;

        public const int CourseMinCapacity = 0;
        public const int CourseMaxCapacity = 30;

        public const string StudentNameCannotBeNull = "Student name cannot be null!";
        public const string IdOutOfRange = "The ID is out of range!";
        public const string CourseIsEmpty = "Students cannot be less than {0}!";
        public const string CourseIsFull = "Students cannot be more than {0}!";
    }
}
