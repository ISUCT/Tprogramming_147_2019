using System;
using System.Collections.Generic;
 
namespace CourseApp
{
    public class AgeClass
    {
        public static DateTime CompareTheDate(DateTime d1, DateTime d2)
        {
            if (d1.Ticks < d2.Ticks)
            {
                DateTime result = new DateTime(d2.Ticks - d1.Ticks);
                return result;
            }
 
            throw new Exception();
        }
        public static string Age()
        {
            Console.WriteLine("Введите год своего рождения:");
            int years = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите месяц своего рождения:");
            int months = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите день своего рождения:");
            int days = Convert.ToInt32(Console.ReadLine());
            DateTime BirthDay = new DateTime(years, months, days);
            DateTime result = new DateTime(DateTime.Now.Ticks - BirthDay.Ticks);
            return $"Вам {result.Year - 1} лет, {result.Month - 1} месяцев и {result.Day - 1} дней";
        }
 
        public static string Age(int years, int months, int days)
        {
            DateTime result = CompareTheDate(new DateTime(years, months, days), DateTime.Now);
            return $"Вам {result.Year - 1} лет, {result.Month - 1} месяцев и {result.Day - 1} дней";
        }
        public static string Age(DateTime date)
        {
            return $"Вам {CompareTheDate(date, DateTime.Now).Year - 1} лет, {CompareTheDate(date, DateTime.Now).Month - 1} месяцев и {CompareTheDate(date, DateTime.Now).Day - 1} дней";
        }
    }
}