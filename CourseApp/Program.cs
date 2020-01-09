using System;
using System.Collections.Generic;

namespace CourseApp
{
    public class Program
    {
        public static double MyFunction(double x)
        {
            var c = Math.Pow(Math.Abs((x * x) - 2.5), 1.0 / 4.0) + Math.Pow(Math.Log10(x * x), 1.0 / 3.0);
            return c;
        }

        public static List<double> TaskA (
                                     double xn,
                                     double xk,
                                     double dx)
        {
            var steps = (int)Math.Floor((xk - xn) / dx);
            var y = new List<double>();
            var i = 0;
            for (var x = xn; x < xk; x += dx)
            {
                y.Add(MyFunction(x));
                i++;
            }

            return y;
        }

        public static List<double> TaskB (
                                 List<double> x)
        {
            var y = new List<double>();
            for (int i = 0; i < x.Count; i++)
            {
                y.Add(MyFunction(x[i]));
            }

            return y;
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var taskA = TaskA(1.25, 3.25, 0.4);
            Console.WriteLine(taskA);

            for (var i = 0; i < taskA.Count; i++)
            {
                Console.WriteLine($"y={taskA[i]}");
            }

            var xB = new List<double> { 1.84, 2.71, 3.81, 4.56, 5.62 };
            var taskB = TaskB(xB);
            for (var i = 0; i < xB.Count; i++)
            {
                Console.WriteLine($"x={xB[i]} y={taskB[i]}");
            }

            Console.WriteLine("==========");

            Transport[] ar = new Transport[2];
            ar[0] = new Motocycle("harley davidson", 2005, 60, 300);
            ar[1] = new Auto("BMW x5", 2010, 120, "white");
            foreach (var item in ar)
            {
                Console.WriteLine(item);
                Console.WriteLine(item.ToString());
                Console.WriteLine(item.Info());
                Console.WriteLine();
            }

            Console.WriteLine("==========");
            Console.WriteLine("Введите год своего рождения:");
            int years = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите месяц своего рождения:");
            int months = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите день своего рождения:");
            int days = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(AgeClass.Age(new DateTime(years, months, days)));
            Console.WriteLine("==========");

            Console.ReadLine();
        }
    }
}
