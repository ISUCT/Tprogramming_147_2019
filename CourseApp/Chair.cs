using System;

namespace CourseApp
{
    public class Chair : Furniture
    {
        public Chair(double weight, double height, string color = "white", int countLegs = 4): base(weight, height, color)
        {
            CountLegs = countLegs;
        }

        public override void Build() {
            Console.WriteLine("Build chair.");
        }

        public override string ToString()
        {
            return $"Chair: Weigh = {Weight}, Height = {Height}, Color = {Color}, Count legs = {CountLegs}";
        }
    }
}