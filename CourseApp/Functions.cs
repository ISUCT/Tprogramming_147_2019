using System;
using System.Collections.Generic;

namespace CourseApp
{
    public class Functions
    {
        public static double MyFunction(double a, double b, double x)
        {
            var y = (a + Math.Pow(Math.Tan(b * x), 2)) / (b + (1 / Math.Pow(Math.Tan(a * x), 2)));
            return y;
        }

        public static List<double> TaskA (
                                     double a,
                                     double b,
                                     double xn,
                                     double xk,
                                     double dx)
        {
            if (dx > (xk - xn))
            {
                List<double> y = new List<double>();
                return y;
            }

            if (xn < xk)
            {
                List<double> y = new List<double>();
                for (double x = xn; x < xk; x += dx)
                {
                    y.Add(MyFunction(a, b, x));
                }

                return y;
            }
            else
            {
                List<double> y = new List<double>();
                return y;
            }
        }

        public static List<double> TaskB (
                                 double a,
                                 double b,
                                 List<double> x)
        {
            List<double> y = new List<double>();
            for (var i = 0; i < x.Count; i++)
            {
                y.Add(MyFunction(a, b, x[i]));
            }

            return y;
        }

        public static void Main(string[] args)
        {
            const double a = 0.1;
            const double b = 0.5;
            const double xn = 0.15;
            const double xk = 1.37;
            const double dx = 0.25;
            Console.WriteLine("TaskA:");
            foreach (var item in TaskA(a, b, xn, xk, dx))
            {
                Console.WriteLine($"y={item}");
            }

            Console.WriteLine("TaskB:");
            List<double> x = new List<double> { 0.2, 0.3, 0.44, 0.6, 0.56 };
            foreach (var item in TaskB(a, b, x))
            {
                Console.WriteLine($"y = {item}");
            }

            Console.ReadLine();
        }
    }
}
