using System;
using System.Collections.Generic;
using System.Text;

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
        : base(name, 0, "male")
        {
        }

        public Pig(string name, int age)
        : this(name, age, 0, "male")
        {
        }

        public Pig(string name, int age, int salo, string gender)
        {
            Name = name;
            Age = age;
            Salo = salo;
            Gender = gender;
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