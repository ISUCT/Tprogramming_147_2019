using System;
using System.Collections.Generic;

namespace CourseApp
{
    public class Program
    {
        public static double MyFunction(double a, double x)
        {
             var y = Math.Pow(Math.Log10(a + x), 2) / Math.Pow(a + x, 2);
             return y;
        }

        public static List<double> TaskA(double a, double xn, double xk, double dx)
        {
            List<double> y = new List<double>((int)((xk - xn) / dx));
            for (var x = xn; x < xk; x += dx)
            {
                y.Add(MyFunction(a, x));
            }

            return y;
        }

        public static List<double> TaskB(double a, List<double> x)
        {
            List<double> y = new List<double>();

            for (var i = 0; i < x.Count; i++)
            {
                y.Add(MyFunction(a, x[i]));
            }

            return y;
        }

        public static void Main(string[] args)
        {
            const double a = 2.0;
            const double xn = 1.2;
            const double xk = 4.2;
            const double dx = 0.6;
            Console.WriteLine("Task A:");
            foreach (var item in TaskA(a, xn, xk, dx))
            {
                Console.WriteLine($"y = {item}");
            }

            List<double> x = new List<double> { 1.16, 1.32, 1.47, 1.65, 1.93 };
            Console.WriteLine("Task B:");
            foreach (var item in TaskB(a, x))
            {
                Console.WriteLine($"y = {item}");
            }

            Mouse[] animal = new Mouse[2];
            animal[0] = new Mouse("Larisa", 1, false);
            animal[1] = new Mouse("Karl", 2, true);
            foreach (var item in animal)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}