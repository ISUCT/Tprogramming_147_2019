using System;

namespace CourseApp
{
    public class Program
    {
        public static void ConsoleInput()
        {
            Console.WriteLine("Введите год своего рождения:");
            int years = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите месяц своего рождения:");
            int months = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите день своего рождения:");
            int days = Convert.ToInt32(Console.ReadLine());
            if (days == 0 && months == 0)
            {
                Console.WriteLine(AgeClass.Age(days, months, years));
            }
            else
            {
                Console.WriteLine();
            }
        }

        public static void Main(string[] args)
        {
            ConsoleInput();
            Console.ReadLine();
        }
    }
}
