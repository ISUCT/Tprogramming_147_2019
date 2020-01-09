using System;
using System.Collections.Generic;

namespace CourseApp
{
    public class Pig : Animal
    {
        private int salo;

        public Pig()
        : base("Test")
        {
        }

        public Pig(string name)
        : base(name, 1, "male")
        {
        }

        public Pig(string name, int age, string gender)
        : this(name, age, 1, "male")
        {
        }

        public Pig(string name, int age, int salo, string gender)
        {
            Name = name;
            Age = age;
            Salo = salo;
            Gender = gender;
        }

        public override int Age
        {
            get
            {
                return this.Age;
            }

            set
            {
                if (value >= 1 && value <= 15)
                {
                    base.Age = value;
                }
                else
                {
                    Console.WriteLine("Возраст свиньи должен быть менее 15.");
                }
            }
        }

        public override string Gender
        {
            get
            {
                return this.Gender;
            }

            set
            {
                if (value == "male" || value == "female")
                {
                    this.Gender = value;
                }
                else
                {
                    throw new System.Exception();
                }
            }
        }

        public int Salo
        {
            get
            {
                return this.salo;
            }

            set
            {
                if (value >= 1)
                {
                    this.salo = value;
                }
                else
                {
                throw new System.Exception();
                }
            }
        }

        public override void Voice()
        {
            Console.WriteLine("Хрю-хрю :)");
        }

        public override string ToString()
        {
            return $"Имя:{Name},Возраст:{Age},Cало:{Salo}";
        }

        public void LostSalo()
        {
            this.salo--;
        }
    }
}