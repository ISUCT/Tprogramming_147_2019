using System;
using System.Collections.Generic;

namespace CourseApp
{
    public class Program
    {
        public static double MyFunction(double a, double b, double x)
        {
            var c = Math.Pow(a + b, 2.5) / (1 + Math.Log10(a + (b * x)));
            return c;
        }

        public static List<double> TaskA(
                                     double a,
                                     double b,
                                     double xn,
                                     double xk,
                                     double dx)
        {
            var steps = (int)Math.Floor((xk - xn) / dx);
            var y = new List<double>();
            var i = 0;
            for (var x = xn; x < xk; x += dx)
            {
                y.Add(MyFunction(a, b, x));
                i++;
            }

            return y;
        }

        public static List<double> TaskB(
                                 double a,
                                 double b,
                                 List<double> x)
        {
            var y = new List<double>();
            foreach (double item in x)
            {
                y.Add(MyFunction(a, b, item));
            }

            return y;
        }

        public static void Main(string[] args)
        {
            var taskA = TaskA(2.5, 4.6, 1.1, 3.6, 0.5);
            Console.WriteLine(taskA);

            for (var i = 0; i < taskA.Count; i++)
            {
                Console.WriteLine($"y={taskA[i]}");
            }

            var xB = new List<double> { 1.2, 1.28, 1.36, 1.46, 2.35 };
            var taskB = TaskB(2, 3, xB);
            for (var i = 0; i < xB.Count; i++)
            {
                Console.WriteLine($"x={xB[i]} y={taskB[i]}");
            }
        }
    }
}
