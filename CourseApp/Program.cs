using System;
using System.Collections.Generic;

namespace CourseApp
{
    public class Program
    {
        public static double Formula(double a, double x)
        {
            var y = Math.Pow(a, Math.Pow(x, 2) - 1) - Math.Log10(Math.Pow(x, 2) - 1) + Math.Pow(Math.Sqrt(Math.Pow(x, 2) - 1), 1 / 3);
            return y;
        }

        public static List<double> TaskA(double a, double xn, double xk, double dx)
        {
            if (xk < xn)
            {
                return new List<double>();
            }
            else
            {
                List<double> y = new List<double>((int)((xk - xn) / dx));
                for (double x = xn; x < xk; x += dx)
                {
                    y.Add(Formula(a, x));
                }

                return y;
            }
        }

        public static List<double> TaskB(double a, List<double> x)
        {
            List<double> y = new List<double>();
            for (var i = 0; i < x.Count; i++)
            {
                y.Add(Formula(a, x[i]));
            }

            return y;
        }

        public static void Main(string[] args)
        {
            const double a = 1.6;
            const double xn = 1.2;
            const double xk = 3.7;
            const double dx = 0.5;
            Console.WriteLine("Task А:");
            foreach (var item in TaskA(a, xn, xk, dx))
            {
                Console.WriteLine($"y = {item}");
            }

            Console.WriteLine("Task B:");
            List<double> x = new List<double> { 1.28, 1.36, 2.47, 3.68, 4.56 };
            foreach (var item in TaskB(a, x))
            {
                Console.WriteLine($"y = {item}");
            }

            Person[] people = new Person[2];
            people[0] = new Person("Sasha", "Smirnov", 25);
            people[1] = new Person("Polina", "Suvorova", 22);
            foreach (var item in people)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
