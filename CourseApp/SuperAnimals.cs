using System;
using System.Collections.Generic;

namespace CourseApp
{
    public abstract class SuperAnimals
    {
        public SuperAnimals(string name, int age, string sex)
        {
        Name = name;
        Age = age;
        Sex = sex;
        }

        public string Name { get; set; }

        public virtual string Sex { get; set; }

        public virtual int Age { get; set; }

        public new abstract string ToString();

        public abstract string Vote();

        public abstract string Runningspeed();

        public virtual void AgeUp()
        {
            this.Age++;
        }

        public virtual string VirtualView()
        {
            return "Virtual Metod";
        }
    }
}