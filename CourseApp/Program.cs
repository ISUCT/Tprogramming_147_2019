using System;

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
            var resA = TaskA(a, xn, xk, dx);
            Console.WriteLine("Задание А:");
            foreach (var item in resA)
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
