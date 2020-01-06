using System;

namespace CourseApp
{
    public class Table : Furniture
    {
        public Table(double weight, double height, string color = "black",  int countLegs = 4): base(weight, height, color)
        {
            CountLegs = countLegs;
        }

        public double CountLegs { get; private set; }

        public override void Build() {
            Console.WriteLine("Build table.");
        }

        public override string ToString()
        {
            return "Table: Weigh = " + Weight + ", Height = " + Height + ", Color = " + Color + ", Count legs = " + CountLegs;
        }
    }
}