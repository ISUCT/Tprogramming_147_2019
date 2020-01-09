using System;
using System.Collections.Generic;

namespace CourseApp
{
    public class Program
    {
        public static double MyFunction(double a, double x)
        {
            var c = Math.Pow(Math.Log10(a + x), 2) / Math.Pow(a + x, 2);
            return c;
        }

        public static List<double> TaskA (
                                     double a,
                                     double xn,
                                     double xk,
                                     double dx)
        {
            var y = new List<double>();
            for (var x = xn; x < xk; x += dx)
            {
                y.Add(MyFunction(a, x));
            }

            return y;
        }

        public static List<double> TaskB (
                                 double a,
                                 List<double> x)
        {
            var y = new List<double>();
            for (int i = 0; i < x.Count; i++)
            {
                y.Add(MyFunction(a, x[i]));
            }

            return y;
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var taskA = TaskA(2, 1.2, 4.2, 0.6);

            for (var i = 0; i < taskA.Count; i++)
            {
                Console.WriteLine($"y={taskA[i]}");
            }

            var xB = new List<double> { 1.16, 1.32, 1.47, 1.65, 1.93 };
            var taskB = TaskB(2, xB);
            for (var i = 0; i < xB.Count; i++)
            {
                Console.WriteLine($"x={xB[i]} y={taskB[i]}");
            }

            var item = new Mouse();
            Console.WriteLine(item.ToString());
            Console.WriteLine(item.View());
            Console.WriteLine(item.Peep());

            Console.ReadLine();
        }
    }
}
