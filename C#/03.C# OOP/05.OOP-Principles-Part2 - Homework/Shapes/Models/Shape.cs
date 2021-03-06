﻿namespace Shapes.Models
{
    public abstract class Shape
    {
        private double width;
        private double height;
        
        protected Shape(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public double Width { get; set; }

        public double Height { get; set; }

        public abstract double CalculateSurface();
    }
}
