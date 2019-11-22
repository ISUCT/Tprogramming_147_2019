using System;

namespace CourseApp
{
    public class Dog
    {
        public Dog()
        {
            Pol = "K";
            Age = 15;
            Weight = 50.0f;
        }

        public Dog(string n)
        {
            Pol = n;
            if (Pol == "S")
            {
                Age = 12;
                Weight = 45.0f;
            }
            else
            {
                Age = 14;
                Weight = 50.0f;
            }
        }
        public float Weight { get; set; }

        public int Age { get; set; }

        public string Pol { get; set; }

        public void GetInfo()
        {
            Console.WriteLine($"Пол: {Pol} Возраст: {Age} Вес: {Weight}");
        }

        public string GetVoice()
        {
            return $"собака возраста {Age} подала голос гав-гав ";
        }

        public string GetPicture()
        {
            return @"  __      _
o'')}____//
 `_/      )
 (_(_/-(_/";
        }
    }
}