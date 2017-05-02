namespace Events
{
    using System;
    using System.Text;

    public class Event : IComparable
    {
        private DateTime date;
        private string title;
        private string location;

        public Event(DateTime date, string title, string location)
        {
            this.date = date;
            this.title = title;
            this.location = location;
        }

        public int CompareTo(object obj)
        {
            Event other = obj as Event;

            int date = this.date.CompareTo(other.date);
            int title = this.title.CompareTo(other.title);

            int byLocation = this.location.CompareTo(other.location);
            if (date == 0)
            {
                if (title == 0)
                {
                    return byLocation;
                }
                else
                {
                    return title;
                }
            }
            else
            {
                return date;
            }
        }

        public override string ToString()
        {
            StringBuilder toString = new StringBuilder();
            toString.Append(date.ToString("yyyy-MM-ddTHH:mm:ss"));

            toString.Append(" | " + title);

            if (this.location != null && this.location != "")
            {
                toString.Append(" | " + location);
            }

            return toString.ToString();
        }
    }
}
