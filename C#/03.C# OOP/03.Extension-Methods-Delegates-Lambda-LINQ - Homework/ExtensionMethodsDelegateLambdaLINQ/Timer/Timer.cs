namespace ExtensionMethodsDelegateLambdaLINQ.Timer
{
    using System;
    using System.Threading;

    public class Timer
    {
        //have to set in <> custom EventArgs
        public EventHandler<TimerEventArgs> Task;

        public Timer(int interval)
        {
            this.Interval = interval;
        }

        public int Interval { get; private set; }

        public void Start()
        {
            if (this.Interval == 0 || this.Interval < 0)
            {
                throw new ArgumentException("Time interval cannot be negative or zero!");
            }
            while (true)
            {

                if (Task != null)
                {
                    Thread.Sleep(this.Interval);

                    var args = new TimerEventArgs();
                    Task(this, args);
                }
            }
        }
    }
}
