using System;

namespace CourseApp
{
    public class AgeClass
    {
        public static string Age(int days, int months, int years)
        {
            DateTime result = DateCompare(new DateTime(years, months, days), DateTime.Now);
            return $"Вам {result.Year - 1} лет, {result.Month - 1} месяцев и {result.Day - 2} дня";
        }

        public static DateTime DateCompare(DateTime date1, DateTime date2)
        {
            if (date1.Date < date2.Date)
            {
                return new DateTime(date2.Ticks - date1.Ticks);
            }

            if (date1.Year == date2.Year && date1.Month == date2.Month && date1.Day == date2.Day)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Понимаю, только родился");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Добро пожаловать в прошлое");
                Console.ResetColor();
            }

            throw new Exception();
        }
    }
}
