using System;
using System.Collections.Generic;
using System.Text;

namespace CourseApp
{

    public class Cat : Animal, IFacts
    {
        public Cat()
        : this("Неизвестно")
        {
        }

        public Cat(string name)
        : this(name, 1)
        {
        }

        public Cat(string name, int age)
        : this(name, age, false)
        {
        }

        public Cat(string name, int age, bool isMale)
        : this(name, age, isMale, true)
        {
        }

        public Cat(string name, int age, bool isMale, bool brood)
        : base(name, age, isMale)
        {
            this.Brood = brood;
        }

        public override int Age
        {
            set
            {
                if (value >= 0 && value < 16)
                {
                    base.Age = value;
                }
                else
                {
                    throw new System.Exception("Age should be more 0 and less than 16");
                }
            }
        }

        public bool Brood { get; set; }

        public override string ToString()
        {
            return $"I am {(Brood ? "thoroughbred" : "mongrel")} {Name}. I am {(IsMale ? "male" : "female")} {Age} years old.";
        }

        public override string Voice()
        {
            return "Meow";
        }

        void IFacts.Facts() => Console.WriteLine("Сердце кошки бьется около 140 ударов в минуту.\nМяуканьем кошки пытаются обратить внимание человека.\n Усы, необходимы кошке для перемещения в пространстве.");
    }
}