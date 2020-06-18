using System;

namespace CourseApp
{
    public class Pig
    {
        private int salo;
        private int age;

        public Pig()
        : this("Untitled", 1, 1, "Male")
        {
        }

        public Pig(string name, int age, int salo, string gender)
        {
            Name = name;
            Age = age;
            Salo = salo;
            Gender = gender;
        }

        public string Name { get; set; }

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
                         Console.WriteLine("Возраст свиньи должен быть меньше 10");
                        }
                }
            }

        public string Gender { get; set; }

        public string IsPoisoned
        {
            get { return this.Gender; }
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

        public void Eat()
        {
            Console.WriteLine("Nem Nem");
        }

        public void Old()
        {
            this.age++;
        }

        public void LostSalo()
        {
            this.salo--;
        }

        public string View()
        {
            return @"PIGGEER";
        }
    }
}