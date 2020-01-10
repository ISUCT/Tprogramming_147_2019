using System;
using System.Collections.Generic;

namespace CourseApp
{
    public class Pig
    {
        private int salo;
        private int age;
        private string gender;
        public string Name { get; set; }
        public Pig()
        : this("Test")
        {
        }

        public Pig(string name)
        : this(name, 1,"male")
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

        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                if (value >= 1 && value <= 15)
                {
                    this.age = value;
                }
                else
                {
                    Console.WriteLine("Возраст свиньи должен быть менее 15.");
                }
            }
        }
        public string Gender
        {
            get
            {
                return this.gender;
            }
            set
            {
                if (value == "male" || value == "female")
                {
                    this.gender = value;
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
                if (value >= 0)
                {
                    this.salo = value;
                }
                else
                {
                throw new System.Exception();
                }
            }
        }

        public override string ToString()
        {
            return $"Имя:{Name},Возраст:{Age},Cало:{Salo}";
            return @"       _       
      (_)      
 _ __  _  __ _ 
| '_ \| |/ _` |
| |_) | | (_| |
| .__/|_|\__, |
| |       __/ |
|_|      |___/ 
";
        }
        public void Aging()
        {
            this.age++;
        }
        public void LostSalo()
        {
            this.salo--;
        }
    }
}
