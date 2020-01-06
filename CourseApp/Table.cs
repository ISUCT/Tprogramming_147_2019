using System;

namespace CourseApp
{
    public class Table
    {
        public Table(double weight, double height, string color = "black")
        {
            if (weight == 0 || height == 0 || string.IsNullOrEmpty(color))
            {
                throw new ArgumentException();
            }

            Weight = weight;
            Height = height;
            Color = color;
        }

        public double Weight { get; private set; }

        public double Height { get; private set; }

        public string Color { get; private set; }

        public override string ToString()
        {
            return "Weight = " + Weight + ", Height = " + Height + ", Color = " + Color;
        }
    }
}