using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Program
    {
        public static double MyFunction(double x)
        {
            return Math.Pow(Math.Pow(Math.Asin(x), 4) + Math.Pow(Math.Acos(x), 6), 1.0 / 7.0);
        }

        public static double[] TaskA(double xn, double xk, double dx)
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

        public static double[] TaskB(double[] x)
        {
            var y = new double[x.Length];
            for (int i = 0; i < x.Length; i++)
            {
                y[i] = MyFunction(x[i]);
            }
            return y;
        }

        static void Main(string[] args)
        {
            var taskA = TaskA(0.22, 0.92, 0.14);
            for (var i = 0; i < taskA.Length; i++)
            {
                Console.WriteLine($"y={taskA[i]}");
            }
            Console.WriteLine("");


            var xB = new double[] { 0.1, 0.35, 0.4, 0.55, 0.6 };
            var taskB = TaskB(xB);
            for (var i = 0; i < xB.Length; i++)
            {
                Console.WriteLine($"x={xB[i]} y={taskB[i]}");
            }
            Console.ReadKey();
        }
    }
}
