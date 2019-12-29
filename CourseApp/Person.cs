using System;

namespace CourseApp
{
    public abstract class Person
    {
        private int age;

        public Person()
        : this("Name")
        {
        }

        public Person(string name)
        : this(name, "LastName")
        {
        }

        public Person(string name, string lastname)
        : this(name, lastname, 18)
        {
        }

        public Person(string name, string lastname, int age)
        : this(name, lastname, age, true)
        {
        }

        public Person(string name, string lastname, int age, bool isMale)
        {
            this.Name = name;
            this.LastName = lastname;
            this.age = age;
            this.IsMale = isMale;
        }

        public virtual int Age
        {
            get
            {
                return this.age;
            }

            set
            {
                if (value >= 0 && value < 100)
                {
                    this.age = value;
                }
                else
                {
                    throw new System.Exception("Age should be more 0 and less than 100");
                }
            }
        }

        public string Name { get; set; }

        public string LastName { get; set; }

        public bool IsMale { get; set; }

        public override string ToString()
        {
            string s = $"Hi. I am {Name} {LastName}. I am {Age} years old. I am a {(IsMale ? "male" : "female")}";
            return s;
        }

        public abstract string Replica();
        public override string ToString()
        {
            string s = $"Hi. I am {Name} {LastName}. I am {Age} years old.";
            return s;
        }
    }
}