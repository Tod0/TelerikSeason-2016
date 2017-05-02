﻿namespace Shapes.Models
{
    public class Square : Shape
    {
        public Square(double side) : base(side, side)
        {

        }

        public override double CalculateSurface()
        {
            return this.Height * this.Width;
        }

        public override string ToString()
        {
            return $"Square with side = {this.Width} has surface = {this.CalculateSurface()}";
        }
    }
}
