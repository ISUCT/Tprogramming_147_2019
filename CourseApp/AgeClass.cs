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
            if (date1.Ticks < date2.Ticks)
            {
                return new DateTime(date2.Ticks - date1.Ticks);
            }

            if (date1.Date == date2.Date)
            {
                throw new Exception("Понимаю, только родился");
            }

            throw new Exception("Добро пожаловать в прошлое");
        }
    }
}
