using System;

namespace CourseApp
{
    public class Pig
    {
        public Pig()
        {
            Sex = "Male";
            Age = 20;
            Salo = 70.0f;
        }
        public Pig(string n)
        {
            Sex = n;
            if (Sex == "Female")
            {
                Age = 15;
                Salo = 45.0f;
            }
            else
            {
                Age = 20;
                Salo = 70.0f;
            }
        }
        public Pig(float s)
        {
            Salo = s;
            if (Salo <= 70.0f && Salo > 45.0f)
            {
                Sex = "Male";
                Age = 20;
            }

            if (Salo <= 45.0f && Salo >= 30.0f)
            {
                Sex = "Female";
                Age = 15;
            }

            if (Salo < 30.0f || Salo > 70.0f)
            {
                Console.WriteLine("ОШИБКА!Вес должен попадать в диапазон от 30 до 70");
                throw new Exception();
            }
        }

        public Pig(int a)
        {
            Age = a;
            if (Age > 15 && Age <= 20)
            {
                Sex = "Male";
                Salo = 65.0f;
            }

            if (Age <= 15 && Age > 1)
            {
                Sex = "Female";
                Salo = 45.0f;
            }

            if (Age < 1 || Age > 20)
            {
                Console.WriteLine("ОШИБКА!Возраст должен попадать в диапазон от 1 до 20");
                throw new Exception();
            }
        }

        public float Salo { get; set; }
        public int Age { get; set; }
        public string Sex { get; set; }
        public void Info()
        {
            Console.WriteLine($"Пол: {Sex}  Возраст: {Age}  Масса сало: {Salo}");
            Console.WriteLine(Dirt());
        }
        public string Dirt()
        {
            return $"свинья возраста {Age} пошла поваляться в грязи  ";
        }
        public string Image()
        {
            return @"       _       
      (_)      
 _ __  _  __ _ 
| '_ \| |/ _` |
| |_) | | (_| |
| .__/|_|\__, |
| |       __/ |
|_|      |___/ 
";
        }
    }
}