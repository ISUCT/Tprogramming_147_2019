using System;
using System.Collections.Generic;

namespace CourseApp
{
    public class Dog
    {
        private int age;
        private string sex;

        public Dog()
        : this("Test")
        {
        }

        public Dog(string name, int age, string sex)
        {
            Name = name;
            Age = age;
            Sex = sex;
        }

        public Dog(string name)
        : this(name, 1, "male")
        {
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
                if (value == "male")
                {
                    this.sex = value;
                }
                else
                {
                    throw new System.Exception();
                }
            }
        }

        public int Age
        {
            get
            {
                return this.age;
            }

            set
            {
                if (value >= 1 && value < 10)
                {
                    this.age = value;
                }
                else
                {
                    throw new System.Exception();
                }
            }
        }

        public override string ToString()
        {
            return $"Имя:{Name},Возраст:{Age},Пол:{Sex}";
        }

        public void AgeUp()
        {
            this.age++;
        }
    }
}