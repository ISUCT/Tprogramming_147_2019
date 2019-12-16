using System;
using System.Collections.Generic;

namespace CourseApp
{
    public class Program
    {
        public static double MyFunction(double a, double x)
        {
            var c = System.Math.Pow(a, System.Math.Pow(x, 2) - 1) - System.Math.Log(System.Math.Pow(x, 2) - 1) + System.Math.Pow(System.Math.Pow(x, 2) - 1, 1.0 / 3);
            return c;
        }

        public static List<double> TaskA(double a, double xn, double xk, double dx)
        {
            List<double> y = new List<double>((int)((xk - xn) / dx));
            for (var x = xn; x < xk; x += dx)
            {
                y.Add(MyFunction(a, x));
        public static double MyFunction(double a, double b, double x)
        {
            var c = (b * x) + (a / x);
            return c;
        }

        public static double[] TaskA (
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

        public static List<double> Taska(double a, double xn, double xk, double dx)
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
              
        public static double[] TaskB (
                                 double a,
                                 double b,
                                 double[] x)
        {
            var y = new double[x.Length];
            for (int i = 0; i < x.Length; i++)
            {
                y[i] = MyFunction(a, b, x[i]);
            }

            return y;
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            double a = 2.25;
            double xn = 1.2;
            double xk = 2.7;
            double dx = 0.3;
            Console.WriteLine("Task 1A:");
            foreach (var item in TaskA(a, xn, xk, dx))
            {
                Console.WriteLine($"y = {item}");
            }

             List<double> x = new List<double> { 1.31, 1.39, 1.44, 1.56, 1.92 };
            Console.WriteLine("Task 1B:");
            foreach (var item in TaskB(a, x))
            {
                Console.WriteLine($"y = {item}");
            }

            string d, e, f;
            int age1, age2, age3;
             Console.WriteLine("Birth year: ");
             d = Console.ReadLine();
             Console.WriteLine("Birth month: ");
             e = Console.ReadLine();
             Console.WriteLine("Birth day: ");
             f = Console.ReadLine();
             age1 = System.Convert.ToInt32(d);
             age2 = System.Convert.ToInt32(e);
             age3 = System.Convert.ToInt32(f);
             var item1 = new BirthDate(age1, age2, age3);
             item1.CalcAge(age1);
            var taskA = TaskA(2, 3, 0, 5, 1);
            Console.WriteLine(taskA);

            for (var i = 0; i < taskA.Length; i++)
            {
                Console.WriteLine($"y={taskA[i]}");
            }

            var xB = new double[] { 0, 1, 2, 3 };
            var taskB = TaskB(2, 3, xB);
            for (var i = 0; i < xB.Length; i++)
            {
                Console.WriteLine($"x={xB[i]} y={taskB[i]}");
            }

            var item = new Platypus();
            Console.WriteLine(item.View());
            Console.ReadLine();
        }
    }
}
