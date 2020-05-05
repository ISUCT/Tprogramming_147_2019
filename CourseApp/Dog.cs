using System;
using System.Collections.Generic;

namespace CourseApp
{
    public class Dog : Animal
    {
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

        public string Breed { get; set; }

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