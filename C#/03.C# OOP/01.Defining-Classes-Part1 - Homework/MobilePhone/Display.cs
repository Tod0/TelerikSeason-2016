namespace MobilePhone
{
    using System.Text;

    class Display
    {
        private double size;
        private int numberOfColors;

        public Display(double size = 0, int numberOfColors = 0)
        {
            this.Size = size;
            this.NumberOfColors = numberOfColors;
        }

        public double Size
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

        public override string ToString()
        {
            return $"Display Size - {this.Size}; Number of Colors - {this.NumberOfColors}";
        }
    }
}
