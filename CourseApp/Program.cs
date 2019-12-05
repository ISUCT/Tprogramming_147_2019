﻿using System;
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

        public static double[] TaskA(
        double a,
        double b,
        double xn,
        double xk,
        double dx)
        {
            var steps = (int)Math.Floor((xk - xn) / dx);
            var y = new double[steps];
            var i = 0;
            for (var x = xn; x < xk; x += dx)
            {
                y[i] = MyFunction(a, b, x);
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

            for (var i = 0; i < taskA.Length; i++)
            {
                Console.WriteLine($"y={taskA[i]}");
            }

            const double a = 1;
            const double b = 0;
            var xB = new List<double> { 0.15, 0.26, 0.37, 0.48, 0.53 };
            var taskB = TaskB(a, b, xB);
            foreach (var res in taskB)
            {
                Console.WriteLine($"y={res}");
            }

            var item = new Platypus();
            Console.WriteLine(item.View());

            Console.ReadLine();
        }
    }
}