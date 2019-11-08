using System;
 
namespace CourseApp
{
    public class Program
    {
            public static double Func(double b, double x)
            {
                 var y = (1 + Math.Pow(Math.Sin(Math.Pow(b, 5) + Math.Pow(x, 5)), 2)) / Math.Pow(Math.Pow(b, 3) + Math.Pow(x, 3), 0.33);
                return y;
            }
        public static double[] TaskA(double b, double xn, double xk, double dx)
        {
            return new double[0];
        }
        public static double[] TaskB(double b, double[] x)
        {
            var y = new double[x.Length];
            for (var i = 0; i < x.Length; i++)
            {
                y[i] = Func(b, x[i]);
            }
            return y;
        }
        public static void Main(string[] args)
        {
            const float b = 2.5f;
            var resultTaskA = Func(b, 4);
            Console.WriteLine($"Answer Task A = {resultTaskA}");
            var x = new double[] { 1.1, 2.4, 3.6, 1.7, 3.9 };
            var resultTaskB = TaskB(b, x);
            Console.WriteLine($"Answer Task B:");
                foreach (var res in resultTaskB)
                {
                    Console.WriteLine($"y= {res}");
                }
        }
    }
}