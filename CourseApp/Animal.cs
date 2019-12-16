using System;
using System.Collections.Generic;

namespace CourseApp
{
    public abstract class Animal
    {
        public int age;
        public string gender;
        public string Name { get; set; }
        public Animal()
        : this("Test")
        {
        }
        public Animal(string name)
        : this(name, 1,"male")
        {
        }
        public Animal(string name, int age, string gender)
        {
            Name = name;
            Age = age;
            Gender = gender;
        }
        public virtual int Age
        {
            get
            {
                return this.age;
            }
            set
            {                
                this.age = value;
            }
        }
        public virtual string Gender
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
        public override string ToString()
        {
            return $"Имя:{Name},Возраст:{Age},Пол:{Gender}";
        }
        public void Ageing()
        {
            this.age++;
        }
        public abstract void Voice();
    }
}