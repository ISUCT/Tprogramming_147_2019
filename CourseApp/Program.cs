// Вариант 20

using System;

using System.Collections;

using System.Collections.Generic;



namespace CourseApp

{

    public class Program

    {

        public static double MyFunction(double a, double b, double x)

        {
            var c = Math.Pow(x - a, 2 / 3);

            var d = Math.Pow(Math.Abs(x + b), 1 / 5);

            var e = Math.Pow(Math.Pow(x , 2)-(Math.Pow((a + b), 2)), 1 / 9);

            var f = (c + d) / e;

            return f;

        }



        public static List<double> TaskA(

                                         double a,

                                         double b, 

                                         double xn,

                                         double xk,

                                         double dx)

        {

            List<double> y = new List<double>();

            for (var x = xn; x < xk; x += dx)

            {

                y.Add(MyFunction(a, b, x));

            }



            return y;

        }



        public static List<double> TaskB(

                                 double a,

                                 double b,

                                 List<double> x)

        {

            List<double> y = new List<double>(5);

            foreach (double i in x)

            {

                y.Add(MyFunction(a, b, i));

            }



            return y;

        }



        public static void Main(string[] args)

        {

            /*var pieces = new PieceOfArt[] { new Film(), new Picture() };



            for (int i = 0; i < 2; i++)

            {

             Console.WriteLine(pieces[i].Send("Tommy"));

            }



            Console.WriteLine("HELLO");*/

            List<double> taskA = TaskA(0.8, 0.4, 1.23, 7.23, 1.2);


            foreach (var item in taskA)

            {

                Console.WriteLine($"y={item}");

            }



            List<double> xB = new List<double>() { 1.88, 2.26, 3.84, 4.55, -6.21 };

            List<double> taskB = TaskB(0.8, 0.4, xB );

            for (int i = 0; i < 5; i++)

            {

                Console.WriteLine($"x={xB[i]}");

            }



            foreach (var item in taskB)

            {

                Console.WriteLine($"y={item}");

            }



            Console.ReadLine();

        }

    }

}