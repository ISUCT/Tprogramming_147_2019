using System;
using System.Collections;
using System.Collections.Generic;

namespace CourseApp
{
    public class Function
    {
        public static double MyFunction(double x)
        {
            var c = (Math.Pow(Math.Sin(x), 3) + Math.Pow(Math.Cos(x), 3)) * Math.Log10(x);
            Console.WriteLine(c);
            return c;
        }

        public static List<double> TaskA(
                                     double xn,
                                     double xk,
                                     double dx)
        {
            List<double> y = new List<double>();
            for (var x = xn; x < xk; x += dx)
            {
                y.Add(MyFunction(x));
            }

            return y;
        }

        public static List<double> TaskB (
                                 List<double> x)
        {
            List<double> y = new List<double>(5);
            foreach (double i in x)
            {
                y.Add(MyFunction(i));
            }

            return y;
        }

        public static void Main(string[] args)
        {
            MyFunction(0);
            Console.WriteLine("Hello World!");
            List<double> taskA = TaskA(0.11, 0.36, 0.05);
            Console.WriteLine(taskA);

            foreach (var item in taskA)
            {
                Console.WriteLine($"y={item}");
            }

            List<double> xB = new List<double>() { 0.2, 0.3, 0.38, 0.43, 0.57 };
            List<double> taskB = TaskB(xB);
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"x={xB[i]}");
            }

            foreach (var item in taskB)
                {
                    Console.WriteLine($"y={item}");
                }

            var ageCalc = new AgeCalc();
            Console.WriteLine(ageCalc.CalcAge(22, 10, 2000));

            Console.ReadLine();
        }
    }
}
