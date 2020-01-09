using System;

namespace CourseApp
{
    public class Motocycle : Transport
    {
        private int power;

        public Motocycle()
        : base("Untitled", 1999, 40)
        {
            this.power = 100;
        }

        public Motocycle(string name, int year, int speed, int power)
        : base(name, year, speed)
        {
            this.power = power;
        }

        public int Power
        {
            get
            {
                return this.power;
            }

            set
            {
                if (value > 0)
                {
                    this.power = value;
                }
                else
                {
                    throw new System.Exception("Power should be more 0");
                }
            }
        }

        public override string Info()
        {
            string s = $"The motorcycle has a capacity of {Power} horsepower.";
            return s;
        }

        public override string ToString()
        {
            string s = $"The motocycle {Name}({Year}) is moving at a speed of {Speed} km/h.";
            return s;
        }
    }
}