using System;

namespace CourseApp
{
    public class Mouse
    {
        private int age;

        public Mouse()
        : this(0, "Untitled", true)
        {
        }

        public Mouse(int age, string name, bool isMale)
        {
            Name = name;
            Age = age;
            IsMale = isMale;
        }

        public string Name { get; set; }

        public int Age
        {
            get
            {
                return this.age;
            }

            set
            {
                if (value >= 0 && value < 20)
                {
                    this.age = value;
                }
                else
                {
                    throw new System.Exception("Age should be > 0 and < than 20");
                }
            }
        }

        public bool IsMale { get; set; }

        public string View()
        {
            return "```оО````\n ```•._)~``\n ``````````";
        }

        public string Peep()
        {
            return "Mouse squeaks.";
        }

        public override string ToString()
        {
            string s;
            if (this.IsMale)
            {
                s = "He";
            }
            else
            {
                s = "She";
            }

            return $"The mouse's name is {Name}.{s} is {Age} years old.";
        }
    }
}