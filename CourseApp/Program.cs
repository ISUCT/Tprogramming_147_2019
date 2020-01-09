using System.Collections;
using System.Collections.Generic;
using System;

namespace CourseApp
{
    public class Program
    {
        public static double MyFunction(double x)
        {
            var y = Math.Pow(Math.Pow(Math.Asin(x), 2) + Math.Pow(Math.Acos(x), 4), 3);
            return y;
        }

        public static List<double> TaskA(
                                     double xn,
                                     double xk,
                                     double dx)
        {
            List<double> y = new List<double>();
            for (var x = xn; x < xk; x += dx)
            {
                y.Add(MyFunction(x));
            }

            return y;
        }

        public static List<double> TaskB(
                                 List<double> x)
        {
            List<double> y = new List<double>(5);
            foreach (double i in x)
            {
                y.Add(MyFunction(i));
            }

            return y;
        }

        public static void Main(string[] args)
        {
            var characters = new Character[] { new Hero(), new Enemy() };
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine(characters[i].Shoot(true));
            }

            Console.WriteLine(MyFunction(0.3));
            List<double> taskA = TaskA(0.26, 0.66, 0.08);
            foreach (var item in taskA)
            {
                Console.WriteLine($"y={item}");
            }

            List<double> xB = new List<double> { 0.1, 0.35, 0.4, 0.55, 0.6 };
            List<double> taskB = TaskB(xB);
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"x={xB[i]}");
            }

            foreach (var item in taskB)
            {
                Console.WriteLine($"y={item}");
            }

            var countAge = new AgeCounter();
            Console.WriteLine(countAge.CountAge(20, 10, 2010));
        }
    }
}
