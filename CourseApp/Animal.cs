using System;

namespace CourseApp
{
    public abstract class Animal
    {
        private int age;

        public Animal()
        : this("Неизвестно")
        {
        }

        public Animal(string name)
        : this(name, 0)
        {
        }

        public Animal(string name, int age)
        : this(name, age, true)
        {
        }

        public Animal(string name, int age, bool isMale)
        {
            this.Name = name;
            this.Age = age;
            this.IsMale = isMale;
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

        public string Name { get; set; }

        public bool IsMale { get; set; }

        public override string ToString()
        {
            return $"Имя:{Name},Возраст:{Age}";
        }

        public abstract string Voice();
    }
}