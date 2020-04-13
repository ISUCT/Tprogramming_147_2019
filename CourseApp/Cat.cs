using System;
using System.Collections.Generic;

namespace CourseApp
{
    public class Cat : Animals
    {
        private int age;

        public Cat()
        : base()
        {
        }

        public Cat(string name)
        : base(name)
        {
        }

        public Cat(string name, int age, string sex)
        : base(name, age, sex)
        {
        }

        public override int Age
        {
            get
            {
                return this.age;
            }

            set
            {
                if (value > 0 && value < 17)
                {
                    this.age = value;
                }
                else
                {
                    throw new System.Exception();
                }
            }
        }

        public override void Move()
        {
            Console.WriteLine("Кот крадётся");
        }

        public override string RunningSpeed()
        {
            return "Средняя скорость домашнего кота во время бега - 43 - 45 км/ч, максимальная - до 50 км/ч";
        }

        public override string ToString()
        {
            return (Sex == "male") ? $"Кот по имени {Name}. Его возраст - {Age}, пол - мужской" : $"Кошка по имени {Name}. Её возраст - {Age}, пол - женский";
        }

        public override void Info()
        {
            Console.WriteLine(this.ToString());
            Console.WriteLine(this.RunningSpeed());
            this.Move();
        }
    }
}