using System;
using System.Collections.Generic;

namespace CourseApp
{
    public class Program
    {
        public static double Function(double a, double x)
        {
            var y = Math.Pow(Math.Log10(a + x), 2) / Math.Pow(a + x, 2);

            return y;
        }

        public static List<double> TaskA(double a, double xn, double xk, double dx)
        {
            int k = 0;
            List<double> y = new List<double>(5);
            for (var i = xn; i < xk; i += dx)
                {
                    y.Add(Function(a, i));
                    k++;
                }

            return y;
        }

        public static List<double> TaskB(double a, List<double> x)
        {
            List<double> y = new List<double>(5);
            for (var i = 0; i < x.Count; i++)
                {
                    y.Add(Function(a, x[i]));
                }

            return y;
        }

        public static void Main(string[] args)
        {
             double a = 2.0;
             double xn = 1.2;
             double xk = 4.2;
             double dx = 0.6;
            var resA = TaskA(a, xn, xk, dx);
            Console.WriteLine("==========");
            Console.WriteLine("Задание А:");
            Console.WriteLine("==========");
            foreach (var item in resA)
                {
                    Console.WriteLine($"y = {item}");
                }

            Console.WriteLine("==========");
            List<double> x = new List<double> { 1.16, 1.32, 1.47, 1.65, 1.93 };
            var taskBRes = TaskB(a, x);
            Console.WriteLine("Задание В:");
            Console.WriteLine("==========");
            foreach (var item in taskBRes)
            {
                Console.WriteLine($"y1 = {item}");
            }

            Console.WriteLine("==========");
            Animals[] animals = new Animals[2];
            animals[0] = new Dog("White", 5, "female");
            animals[1] = new Cat("Black");
            foreach (Animals animal in animals)
            {
                animal.Info();
                Console.WriteLine();
            }

           if (animals[0].CompareTo(animals[1]) == 0)
           {
               Console.WriteLine("Животные имеют одинаковую кличку");
           }
           else
           {
               Console.WriteLine("Животные имеют разные клички");
           }
        }
    }
}
