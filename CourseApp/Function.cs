using System;

namespace CourseApp
{
    public class Program
    {
        public static double MyFunction(double x)
        {
            var c = (Math.Pow(Math.Sin(x), 3) + Math.Pow(Math.Cos(x), 3)) * Math.Log10(x);
            return c;
        }

        public static double[] TaskA (
                                     double xn,
                                     double xk,
                                     double dx)
        {
            var steps = (int)Math.Floor((xk - xn) / dx);
            var y = new double[steps];
            var i = 0;
            for (var x = xn; x < xk; x += dx)
            {
                y[i] = MyFunction(x);
                i++;
            }

            return y;
        }

        public static double[] TaskB (
                                 double[] x)
        {
            var y = new double[x.Length];
            for (int i = 0; i < x.Length; i++)
            {
                y[i] = MyFunction(x[i]);
            }

            return y;
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var taskA = TaskA(0.11, 0.36, 0.05);
            Console.WriteLine(taskA);

            for (var i = 0; i < taskA.Length; i++)
            {
                Console.WriteLine($"y={taskA[i]}");
            }

            var xB = new double[] { 0.2, 0.3, 0.38, 0.43, 0.57 };
            var taskB = TaskB(xB);
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
