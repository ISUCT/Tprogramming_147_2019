﻿using System;

namespace CourseApp
{
    public class Program
    {
        public static double[] TaskA(double a, double xn, double xk, double dx)
        {
            int k = 0;
            var y = new double[5];
            for (var i = xn; i < xk; i += dx)
            {
                y[k] = Math.Pow(Math.Log10(a + i), 2) / Math.Pow(a + i, 2);
                k++;
            }
            return y;
        }

        public static double[] TaskB(double a, double[] x)
        {
            var y = new double[x.Length];
            for (var i = 0; i < y.Length; i++)
            {
                y[i] = Math.Pow(Math.Log10(a + x[i]), 2) / Math.Pow(a + x[i], 2);
            }
            return y;
        }

        public static void Main(string[] args)
        {
             double a = 2.0;
             double xn = 1.2;
             double xk = 4.2;
             double dx = 0.6;

            var resSingle = TaskA(a, xn, xk, dx);
            Console.WriteLine("Задание А:");
            foreach (var item in resSingle)
            {
                Console.WriteLine($"y = {item}");
            }

            var x = new double[] { 1.16, 1.32, 1.47, 1.65, 1.93 };
            var taskBRes = TaskB(a, x);
            Console.WriteLine("Задание В:");
            foreach (var item in taskBRes)
            {
                Console.WriteLine($"y1 = {item}");
            }
            Console.ReadLine();
        }
    }
}
