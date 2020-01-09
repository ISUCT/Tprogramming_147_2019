using System;

namespace CourseApp
{
    public class Auto : Transport
    {
        private string color;

        public Auto()
        : this("Untitled")
        {
        }

        public Auto(string name)
        : this(name, 2000)
        {
        }

        public Auto(string name, int year)
        : this(name, year, 60, "black")
        {
        }

        public Auto(string name, int year, int speed, string color)
        : base(name, year, speed)
        {
            this.color = color;
        }

        public string Color
        {
            get
            {
                return this.color;
            }

            set
            {
                if (value == "white" || value == "black" || value == "green")
                {
                    this.color = value;
                }
                else
                {
                    throw new System.Exception();
                }
            }
        }

        public override string Info()
        {
            string s = $"This car is {2020 - Year} years old.";
            return s;
        }

        public override string ToString()
        {
            string s = $"The {Color} car {Name}({Year}) is moving at a speed of {Speed} km/h.";
            return s;
        }
    }
}