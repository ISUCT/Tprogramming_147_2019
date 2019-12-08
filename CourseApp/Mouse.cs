using System;

namespace CourseApp
{
    public class Mouse
    {
        private int age;

        public Mouse()
        : this("Untitled")
        {
        }

        public Mouse(string name)
        : this(name, 0)
        {
        }

        public Mouse(string name, int age)
        : this(name, age, true)
        {
        }

        public Mouse(string name, int age, bool isMale)
        {
            Name = name;
            Age = age;
            IsMale = isMale;
        }

        public string Name { get; set; }

        public bool IsMale { get; set; }

        public int Age
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
                    Console.WriteLine("Age should be > 0 and < than 3");
                }
            }
        }

        public override string ToString()
        {
            string s = $"Piep piep. I am {Name}. I am {(IsMale ? "male" : "female")} {Age} years old.";
            return s;
        }
    }
}