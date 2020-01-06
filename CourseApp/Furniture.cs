using System;

namespace CourseApp
{
    public abstract class Furniture
    {
        public Furniture(double weight, double height, string color)
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

        public abstract void Build();
    }
}