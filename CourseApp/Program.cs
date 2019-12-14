using System;
using System.Collections.Generic;
 
namespace CourseApp
{
    public class Program
    {
            public static double Func(double b, double x)
            {
                 var y = (1 + Math.Pow(Math.Sin(Math.Pow(b, 3) + Math.Pow(x, 3)), 2)) / Math.Pow(Math.Pow(b, 3) + Math.Pow(x, 3), 1/3f);
                return y;
            }
        public static List<double> TaskA(double b, double xn, double xk, double dx)
        {
			int i = 0;
			List<double> y = new List<double>();
			for (double x = xn; x < xk; x += dx)
			{
				y.Add(Func(b, x));
				i++;
			}
			return y;
        }
        public static List<double> TaskB(double b, List<double> x)
        {
            List <double> y = new List<double>();
            for (var i = 0; i < x.Count; i++)
            {
                y.Add(Func(b, x[i]));
            }
            return y;
        }
        public static void Main(string[] args)
        {
			double xn = 1.280;
			double xk = 3.280;
			double dx = 0.4;
			double b = 2.5;
			Console.WriteLine("Answer Task A :");
			   foreach (var item in TaskA(b, xn, xk, dx))
			    {
			     	Console.WriteLine($"y = {item}");
			    }
            List <double> x = new List<double> { 1.1, 2.4, 3.6, 1.7, 3.9 };
            var resultTaskB = TaskB(b, x);
            Console.WriteLine($"Answer Task B:");
                foreach (var item in resultTaskB)
                {
                    Console.WriteLine($"y= {item}");
                }
            Console.WriteLine(AgeClass.Age());
        }
    }
}
