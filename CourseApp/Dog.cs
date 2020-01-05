using System;
using System.Collections.Generic;

namespace CourseApp
{
    public class Dog : Animals
    {
        private int age;

        public Dog()
        : base()
        {
        }

        public Dog(string name)
        : base(name)
        {
        }

        public Dog(string name, int age, string sex)
        : base(name, age, sex)
        {
        }

        public override int Age
        {
            get
            {
                return this.age;
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
                if (value > 0 && value < 14)
                {
                    this.age = value;
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

        public override string RunningSpeed()
        {
            return "Средняя скорость собаки при беге приблизительно равна 10 - 15 км/час";
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
            return (Sex == "male") ? $"Собака по имени {Name}. Его возраст - {Age}, пол - мужской" : $"Собака по имени {Name}. Её возраст - {Age}, пол - женский";
        }

        public override void Info()
        {
            Console.WriteLine(this.ToString());
            Console.WriteLine(this.RunningSpeed());
        }
    }
}
            return $"Имя:{Name},Возраст:{Age},Пол:{Sex}";
        }

        public void AgeUp()
        {
            this.Age++;
        }
    }
}
