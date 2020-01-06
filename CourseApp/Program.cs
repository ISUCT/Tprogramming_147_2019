using System;
using System.Collections.Generic;
using System.Globalization;

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

            Console.WriteLine("Table info:");

            List<Furniture> furniture = new List<Furniture>()
            {
                new Table(500, 120),
                new Table(400, 400, "red"),
                new Chair(100, 100),
                new Chair(120, 120, "yellow"),
                new Chair(100, 100, "red", 4),
                new Chair(120, 120, "yellow", 2),
                new Table(400, 400, countLegs: 3),
            };

            for (int i = 0; i < furniture.Count; i++)
            {
                furniture[i].Build();
                Console.WriteLine(furniture[i].ToString());
            }

            try
            {
                furniture.Add(new Table(0, 12, null));
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
            }

            Console.WriteLine("Birthday info:");
            Birthday birthday = new Birthday(DateTime.Now);
            Console.WriteLine("Birthday equals current date: {0}", birthday);
            birthday = new Birthday(new DateTime(2001, 9, 12));
            Console.WriteLine("Birthday before current date: {0}", birthday);
            birthday = new Birthday(new DateTime(3002, 9, 12));
            Console.WriteLine("Birthday after current date: {0}", birthday);
            Console.ReadLine();
        }
    }
}