namespace ExtensionMethodsDelegateLambdaLINQ.Tests
{
    using Timer;

    public static class TimerTest
    {
        public static void Test()
        {
            // interval is 1000 cuz subscriber counting secs
            var timer = new Timer(1000);
            var subscriber = new Subscriber(10);
            subscriber.Listen(timer);

            timer.Start();
        }
    }
}
