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

            Weigh = weight;
            Height = height;
            Color = color;
        }

        public double Weigh { get; private set; }

        public double Height { get; private set; }

        public string Color { get; private set; }

        public override string ToString()
        {
            return "Weigh = " + Weigh + ", Height = " + Height + ", Color = " + Color;
        }
    }
}