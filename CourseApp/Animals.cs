using System;
using System.Collections.Generic;

namespace CourseApp
{
    public abstract class Animals : IComparable, IMovable
    {
        private string sex;

        public Animals()
        : this("Test")
        {
        }

        public Animals(string name)
        : this(name, 1, "male")
        {
        }

        public Animals(string name, int age, string sex)
        {
            Name = name;
            Age = age;
            Sex = sex;
        }

        public string Name { get; set; }

        public string Sex
        {
            get
            {
                return this.sex;
            }

            set
            {
                if (value == "male" || value == "female")
                {
                    this.sex = value;
                }
                else
                {
                    throw new System.Exception();
                }
            }
        }

        public virtual int Age { get; set; }

        public new abstract string ToString();

        public abstract string RunningSpeed();

        public abstract void Info();

        public virtual void AgeUp()
        {
            this.Age++;
        }

        public virtual void Move()
        {
            Console.WriteLine("Животное идёт");
        }

        public int CompareTo(object o)
        {
            Animals animal = o as Animals;
            if (animal != null)
            {
                if (animal.Name == this.Name)
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
            else
            {
                throw new Exception("Невозможно сравнить два объекта");
            }
        }
    }
}