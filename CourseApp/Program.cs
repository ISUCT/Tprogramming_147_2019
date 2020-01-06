using System;
using System.Collections.Generic;

namespace CourseApp
{
    public class Program
    {
        public static double MyFunction(double a, double b, double x)
        {
            var c = Math.Acos((x * x) - (b * b)) / Math.Asin((x * x) - (a * a));
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
            foreach (double xItem in x)
            {
                y.Add(Math.Acos((xItem * xItem) - (b * b)) / Math.Asin((xItem * xItem) - (a * a)));
            }

            return y;
        }

        public static void Main(string[] args)
        {
            var taskA = TaskA(0.05, 0.06, 0.2, 0.95, 0.15);
            Console.WriteLine(taskA);

            for (var i = 0; i < taskA.Count; i++)
            {
                Console.WriteLine($"y={taskA[i]}");
            }

            const double a = 1;
            const double b = 0;
            var xB = new List<double> { 0.15, 0.26, 0.37, 0.48, 0.53 };
            var taskB = TaskB(a, b, xB);
           for (var i = 0; i < taskB.Count; i++)
            {
                Console.WriteLine($"x={xB[i]} y={taskB[i]}");
            }

            List<Table> tables = new List<Table>()
            {
                new Table(12, 12),
                new Table(12, 12, "red")
            };

            for (int i = 0; i < tables.Count; i++)
            {
                Console.WriteLine(tables[i].ToString());
            }

            try
            {
                tables.Add(new Table(0, 12, null));
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
            }

            Console.ReadLine();   
        }
    }
}