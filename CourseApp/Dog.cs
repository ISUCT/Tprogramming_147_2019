using System;
using System.Collections.Generic;

namespace CourseApp
{
    public class Dog : SuperAnimals
    {
        private int age;
        private string sex;

        public Dog()
        : this("Test")
        {
        }

        public Dog(string name, int age, string sex)
        : base(name, age, sex)
        {
        }

        public Dog(string name)
        : this(name, 1, "male")
        {
        }

        public override string Sex
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

        public override int Age
        {
            get
            {
                return this.age;
            }

            set
            {
                if (value >= 1 && value < 12)
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

        public override void AgeUp()
        {
            this.age++;
        }

        public override string Vose()
        {
            return "gawgaw";
        }

        public override string Runningspeed()
        {
            return "10-15km/h";
        }
    }
}