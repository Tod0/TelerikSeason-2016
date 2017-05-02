namespace School.Utils
{
    using System;

    public class Validator
    {
        public static void ValidateNullOrEmpty(string value, string message)
        {
            if (value == null || value == "")
            {
                throw new ArgumentException(message);
            }
        }

        public static void ValidateIntRange(int value, int min, int max, string message)
        {
            if (value < min || value > max)
            {
                throw new ArgumentException(message);
            }
        }
    }
}
