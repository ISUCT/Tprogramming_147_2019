using System;

namespace CoursApp
{
    public abstract class SuperAnimals
    {
        public SuperAnimals (string name, int age, string sex)
        {
        Name = name;
        Age = age;
        Sex = sex;
        }
        
        public string Name { get; set; }
        
        public string Sex { get; set; }
        
        public virtual int Age { get; set; }
        
        public new abstract string ToString();

        public abstract string Vote();

        public abstract string  Runningspeed();
        
        public void AgeUp()

        {
            this.age++;
        }
        
        public virtual string VirtualView()
        {
            return "Virtual Metod";
        }
    }
}