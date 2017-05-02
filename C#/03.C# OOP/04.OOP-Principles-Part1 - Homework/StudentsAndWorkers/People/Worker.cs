namespace StudentsAndWorkers.People
{
    using System;

    public class Worker : Human
    {
        private double weekSalary;
        private double workHoursPerDay;

        public Worker()
        {

        }

        public Worker(string firstName, string lastName, double weekSalary, double workHoursPerDay) : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        public double WeekSalary
        {
            get
            {
                return this.weekSalary;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Weekly salary must be a positive number!");
                }
                this.weekSalary = value;
            }
        }

        public double WorkHoursPerDay
        {
            get
            {
                return this.workHoursPerDay;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Work hours per day must be a positive number!");
                }
                this.workHoursPerDay = value;
            }
        }

        public double MoneyPerHour()
        {
            double result = (this.WeekSalary / 7) / this.WorkHoursPerDay;

            return result;
        }

        public override string ToString()
        {
            return $"{this.FirstName} {this.LastName} earns {this.MoneyPerHour():F2} money per hour.";
        }
    }
}
