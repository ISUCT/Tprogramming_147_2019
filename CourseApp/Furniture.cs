using System;

namespace CourseApp
{
    public abstract class Furniture : IComparable<Furniture>, IFurniture
    {

        public double Weight { get; set; }

        public double Height { get; set; }

        public string Color { get; set; }

        public int CountLegs { get; set; }

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

        public abstract void Build();

        public int CompareTo(Furniture other)
        {
            if (Height > other.Height && Weight > other.Weight)
            {
                return 1;
            }
            else if (Height < other.Height && Weight < other.Weight)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}