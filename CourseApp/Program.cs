using System;
using System.Collections.Generic;

namespace CourseApp
{
    public class Program
    {
        public static double MyFunction(double a, double b, double x)
        {
            var c = (1 + Math.Log10(x / a)) / (b - Math.Pow(2.71, x / a));
            return c;
        }

        public static List<double> TaskA (
                                     double a,
                                     double b,
                                     double xn,
                                     double xk,
                                     double dx)
        {
            var steps = (int)Math.Floor((xk - xn) / dx);
            var y = new List<double>();
            for (var x = xn; x < xk; x += dx)
            {
                y.Add(MyFunction(a, b, x));
            }

            return y;
        }

        public static List<double> TaskB (
                                 double a,
                                 double b,
                                 List<double> x)
        {
            var y = new List<double>();
            foreach (double i in x)
            {
                 y.Add(MyFunction(a, b, i));
            }

            return y;
        }

        public static void Main(string[] args)
        {
             var taskA = TaskA(2, 0.95, 1.25, 2.75, 0.3);
             Console.WriteLine(taskA);

             for (var i = 0; i < taskA.Count; i++)
             {
             Console.WriteLine($"y={taskA[i]}");
             }

           var xB = new List<double> { 2.2, 3.78, 4.51, 6.58, 1.2 };
           var taskB = TaskB(2, 3, xB);
            for (var i = 0; i < xB.Count; i++)
            {
                Console.WriteLine($"x={xB[i]} y={taskB[i]}");
            }
        }
    }
}
