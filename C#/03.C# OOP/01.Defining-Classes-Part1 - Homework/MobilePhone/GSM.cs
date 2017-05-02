namespace MobilePhone
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    class GSM
    {
        private static readonly GSM iPhone4S = new GSM("iPhone 4S", "Apple", 600, "Steve Jobs", new Battery(BatteryType.LiIon, 48, 24), new Display(4.5, 16000000));

        private string model;
        private string manufacturer;
        private double price;
        private string owner;
        private Battery battery;
        private Display display;
        private List<Call> callHistory = new List<Call>();

        public GSM(string model, string manufacturer, double price = 0, string owner = null, Battery battery = null, Display display = null)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Price = price;
            this.Owner = owner;
            this.Battery = battery;
            this.Display = display;
        }

        public string Model
        {
            get
            {
                return this.model;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Model must be defined!");
                }

                this.model = value;
            }
        }

        public string Manufacturer
        {
            get
            {
                return this.manufacturer;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Manufacturer must be defined!");
                }

                this.manufacturer = value;
            }
        }

        public double Price
        {
            get
            {
                return this.price;
            }
            set
            {
                this.price = value;
            }
        }

        public string Owner
        {
            get
            {
                return this.owner;
            }
            set
            {
                this.owner = value;
            }
        }

        public Battery Battery
        {
            get
            {
                return this.battery;
            }

            set
            {
                this.battery = value;
            }
        }

        public Display Display
        {
            get
            {
                return this.display;
            }

            set
            {
                this.display = value;
            }
        }

        public static GSM IPhone4S
        {
            get
            {
                return iPhone4S;
            }
        }

        public List<Call> CallHistory
        {
            get
            {
                return this.callHistory;
            }
        }

        public override string ToString()
        {
            var output = new StringBuilder();

            output.AppendLine(string.Format("Model: {0}", this.model))
                .AppendLine(string.Format("Manufacturer: {0}", this.manufacturer))
                .AppendLine(string.Format("Price: {0}", this.price))
                .AppendLine(string.Format("Owner: {0}", this.owner))
                .AppendLine(string.Format("Battery: {0}", this.battery.ToString()))
                .AppendLine(string.Format("Display: {0}", this.display.ToString()));

            return output.ToString();
        }

        public void DisplayInfo()
        {
            Console.WriteLine(this.ToString());
        }

        public void AddCall(Call call)
        {
            this.callHistory.Add(call);
        }

        public void AddCallAt(int index, Call call)
        {
            this.callHistory.Insert(index, call);
        }

        public void RemoveCall(Call call)
        {
            this.callHistory.Remove(call);
        }

        public void RemoveCallAt(int index)
        {
            this.callHistory.RemoveAt(index);
        }

        public void ClearCallHistory()
        {
            this.callHistory.Clear();
        }

        public string CallHistoryInfo()
        {
            var callHistoryInfo = new StringBuilder();

            if (this.CallHistory.Count == 0)
            {
                callHistoryInfo.AppendLine("The call history is empty!");
                return callHistoryInfo.ToString();
            }

            callHistoryInfo.AppendLine("Date\t\tTime\t\tDialed number\tDuration in seconds");

            for (int i = 0; i < this.CallHistory.Count; i++)
            {
                callHistoryInfo.AppendLine(this.callHistory[i].ToString());
            }

            return callHistoryInfo.ToString();
        }

        public decimal CallPrice(decimal callPricePerMinute)
        {
            var totalSeconds = 0;

            for (int i = 0; i < this.callHistory.Count; i++)
            {
                totalSeconds += this.callHistory[i].DurationInSeconds;
            }

            decimal price = totalSeconds * (callPricePerMinute / 60);

            return price;
        }

        public void RemoveLongestCall()
        {
            var longestCall = callHistory[0];
            int index = 0;

            for (int i = 0; i < callHistory.Count; i++)
            {
                if (callHistory[i].DurationInSeconds > longestCall.DurationInSeconds)
                {
                    longestCall = callHistory[i];
                    index = i;
                }
            }

            callHistory.RemoveAt(index);
        }
    }
}
