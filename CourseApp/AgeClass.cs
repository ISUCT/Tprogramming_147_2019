using System;

namespace CourseApp
{
    public class AgeClass
    {
        public static string Age(DateTime birthday)
        {
            DateTime res = DateCompare(birthday, DateTime.Now);
            return $"Вам {res.Year - 1} лет, {res.Month - 1} месяцев и {res.Day - 1} дня";
        }

        public static DateTime DateCompare(DateTime date1, DateTime date2)
        {
            if (date1.Ticks < date2.Ticks)
            {
                DateTime res = new DateTime(date2.Ticks - date1.Ticks);
                return res;
            }
            else
            {
                throw new Exception("Birthday > Today");
            }
        }
    }
}