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
            try
            {
                Console.WriteLine(AgeClass.Age(days, months, years));
            }
            catch (Exception)
            {
                Console.WriteLine();
            }
            finally
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
