using System;

namespace CourseApp
{
    public class Mouse : Animal
    {
        private int age;

        public Mouse()
        : this("Неизвестно")
        {
        }

        public Mouse(string name)
        : this(name, 1)
        {
        }

        public Mouse(string name, int age)
        : this(name, age, true)
        {
        }

        public Mouse(string name, int age, bool isMale)
        : this(name, age, isMale, false)
        {
        }

        public Mouse(string name, int age, bool isMale, bool aggression)
        : base(name, age, isMale)
        {
            this.Aggression = aggression;
        }

        public bool Aggression { get; set; }

        public override int Age
        {
            get
            {
                return this.age;
            }

            set
            {
                if (value >= 0 && value < 3)
                {
                    this.age = value;
                }
                else
                {
                    throw new System.Exception("Age should be > 0 and < than 3");
                }
            }
        }

        public override string ToString()
        {
            string s = $"I am {(Aggression ? "aggression" : "friendly")} {Name}. I am {(IsMale ? "male" : "female")} {Age} years old.";
            return s;
        }

        public override string Voice()
        {
            return "Piep, piep";
        }
    }
}