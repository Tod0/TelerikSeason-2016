namespace StudentClass.Utils
{
    using System;

    public class Validator
    {
        public static void NullVerification(string data)
        {
            if (data == null)
            {
                throw new ArgumentException("This information space cannot be left empty!");
            }
        }

        public static void ZeroOrNegative(int data)
        {
            if (data <= 0)
            {
                throw new ArgumentException("This information space cannot be zero or negative");
            }
        }
    }
}
