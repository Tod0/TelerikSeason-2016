namespace School.Utils
{
    using System.Threading;

    public static class IdGenerator
    {
        private static int idCounter;

        static IdGenerator()
        {
            idCounter = Constants.MinimumIdNumber;
        }

        public static int GenerateId()
        {
            return Interlocked.Increment(ref idCounter);
        }
    }
}
