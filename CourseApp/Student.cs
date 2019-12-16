using System;

namespace CourseApp
{
    public class Student : Person
    {
        public Student()
        : this("Name")
        {
        }

        public Student(string name)
        : this(name, "LastName")
        {
        }

        public Student(string name, string lastname)
        : this(name, lastname, 18)
        {
        }

        public Student(string name, string lastname, int age)
        : this(name, lastname, age, true)
        {
        }

        public Student(string name, string lastname, int age, bool isMale)
        : this(name, lastname, age, isMale, true)
        {
        }

        public Student(string name, string lastname, int age, bool isMale, bool starvation)
        : base(name, lastname, age, isMale)
        {
            this.Starvation = starvation;
        }

        public bool Starvation { get; set; }

        public override string ToString()
        {
            string s = $"Hi. I am {Name} {LastName}. I am {Age} years old. I am a {(IsMale ? "male" : "female")} and {(Starvation ? "hungry" : "full")}";
            return s;
        }

        public override string Replica()
        {
            return "I want to go to kindergarten";
        }
    }
}