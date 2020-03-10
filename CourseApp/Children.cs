using System;

namespace CourseApp
{
    public class Children : Person
    {
        public Children()
        : this("Name")
        {
        }

        public Children(string name)
        : this(name, "LastName")
        {
        }

        public Children(string name, string lastname)
        : this(name, lastname, 1)
        {
        }

        public Children(string name, string lastname, int age)
        : this(name, lastname, age, true)
        {
        }

        public Children(string name, string lastname, int age, bool isMale)
        : this(name, lastname, age, isMale, false)
        {
        }

        public Children(string name, string lastname, int age, bool isMale, bool happy)
        : base(name, lastname, age, isMale)
        {
            this.Happy = happy;
        }

        public bool Happy { get; set; }

        public override int Age
        {
            set
            {
                if (value >= 0 && value < 12)
                {
                    base.Age = value;
                }
                else
                {
                    throw new System.Exception("Age should be more 0 and less than 12");
                }
            }
        }

        public override string ToString()
        {
            string s = $"Hi. I am {Name} {LastName}. I am {Age} years old. I am a {(IsMale ? "male" : "female")} and {(Happy ? "unhappy" : "happy")}";
            return s;
        }

        public override string Replica()
        {
            return "I want to go to school";
        }
    }
}