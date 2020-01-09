using System;

namespace CourseApp
{
    public abstract class Transport
    {
        private int speed;

        public Transport(string name, int year, int speed)
        {
            this.speed = speed;
            this.Name = name;
            this.Year = year;
        }

        public int Speed
        {
            get
            {
                return this.speed;
            }

            set
            {
                if (value >= 0 && value < 300)
                {
                    this.speed = value;
                }
                else
                {
                    throw new System.Exception("Speed should be more 0 and less than 300");
                }
            }
        }

        public string Name { get; set; }

        public int Year { get; set; }

        public abstract string Info();
    }
}