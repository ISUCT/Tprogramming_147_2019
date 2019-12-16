using System;

namespace CourseApp
{
    public class Person
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
        {
            this.Name = name;
            this.LastName = lastname;
            this.age = age;
        }

        public int Age
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

        public override string ToString()
        {
            string s = $"Hi. I am {Name} {LastName}. I am {Age} years old.";
            return s;
        }
    }
}