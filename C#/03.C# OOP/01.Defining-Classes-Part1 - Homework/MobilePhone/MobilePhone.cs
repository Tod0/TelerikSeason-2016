using System;

namespace MobilePhone
{
    // TODO: problem 6

    class GSM
    {
        private string model;
        private string manufacturer;
        private double price;
        private string owner;
        private Battery battery;
        private Display display;

        public GSM(string model, string manufacturer, double price = 0, string owner = null)
        {
            this.model = model;
            this.manufacturer = manufacturer;
            this.price = price;
            this.owner = owner;
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

        static

        public override string ToString()
        {
            return 
        }
    }

    public enum BatteryType
    {
        LiIon,
        NiMH,
        NiCd
    }

    class Battery
    {
        private string model;
        private int hoursIdle;
        private int hoursTalk;

        public Battery(string model, int hoursIdle = 0, int hoursTalk = 0)
        {
            this.model = model;
            this.hoursIdle = hoursIdle;
            this.hoursTalk = hoursTalk;
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

        public int HoursIdle
        {
            get
            {
                return this.hoursIdle;
            }
            set
            {
                this.hoursIdle = value;
            }
        }

        public int HoursTalk
        {
            get
            {
                return this.hoursTalk;
            }
            set
            {
                this.hoursTalk = value;
            }
        }

        public BatteryType BatteryType { get; set; }
    }

    class Display
    {
        private int size;
        private int numberOfColors;

        public Display(int size = 0, int numberOfColors = 0)
        {
            this.size = size;
            this.numberOfColors = numberOfColors;
        }

        public int Size
        {
            get
            {
                return this.size;
            }
            set
            {
                this.size = value;
            }
        }

        public int NumberOfColors
        {
            get
            {
                return this.numberOfColors;
            }
            set
            {
                this.numberOfColors = value;
            }
        }
    }

    class GSMTest
    {
        private GSM
    }

    class MobilePhone
    {
        static void Main(string[] args)
        {

        }
    }
}
