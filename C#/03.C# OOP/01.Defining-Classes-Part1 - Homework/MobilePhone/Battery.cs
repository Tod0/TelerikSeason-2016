namespace MobilePhone
{
    using System;
    using System.Text;

    class Battery
    {
        private BatteryType model;
        private int hoursIdle;
        private int hoursTalk;

        public Battery(BatteryType model, int hoursIdle = 0, int hoursTalk = 0)
        {
            this.Model = model;
            this.HoursIdle = hoursIdle;
            this.HoursTalk = hoursTalk;
        }

        public BatteryType Model
        {
            get
            {
                return this.model;
            }
            set
            {
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

        public override string ToString()
        {
            return $"Type - {this.Model}; Hours Talk - {this.HoursTalk}; Hours Idle - {this.HoursIdle}";
        }
    }
}
