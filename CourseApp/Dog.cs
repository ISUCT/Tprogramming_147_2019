using System;
using System.Collections.Generic;

namespace CourseApp
{
    public class Dog : Animal
    {
        public string Breed { get; set; }
        public Dog()
        : this("Test")
        {
        }
        public Dog(string name)
        : this(name, 0, "male")
        {
        }
        public Dog(string name, int age, string gender)
        {
            Name = name;
            Age = age;
            Gender = gender;
        }
        public Dog(string name, string breed)
        : base(name)
        {
            Breed = breed;
        }
        public override int Age
        {
            set
            {
                if (value >= 0 && value <= 15)
                {
                    base.Age = value;
                }
                else
                {
                    throw new System.Exception();
                }
            }
        }
        public override void Voice()
        {
            Console.WriteLine("гав :D");
        }
        public override string ToString()
        {
            return $"Имя:{Name},Возраст:{Age},Пол:{Gender},Порода:{Breed}";
        }
    }
}