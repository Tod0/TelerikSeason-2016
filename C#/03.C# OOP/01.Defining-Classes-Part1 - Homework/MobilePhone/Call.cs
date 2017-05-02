namespace MobilePhone
{
    using System;

    class Call
    {
        public Call(DateTime dateTime, string phoneNumber, int duration)
        {
            this.Date = dateTime.ToShortDateString();
            this.Time = dateTime.ToLongTimeString();
            this.DialedPhone = phoneNumber;
            this.DurationInSeconds = duration;
        }

        public string Date { get; private set; }

        public string DialedPhone { get; private set; }

        public int DurationInSeconds { get; private set; }

        public string Time { get; private set; }

        public override string ToString()
        {
            return $"{this.Date}\t{this.Time}\t{this.DialedPhone}\t\t{this.DurationInSeconds}";
        }
    }
}
