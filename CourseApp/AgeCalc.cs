using System;

namespace CourseApp
{
    public class AgeCalc
    {
        private DateTime now = DateTime.Today;

        public string CalcAge(int day, int month, int year)
        {
            var birthday = new DateTime(year, month, day);
            var today = DateTime.Today;

            if (now.Ticks < birthday.Ticks)
            {
                throw new Exception("You haven't been born yet");
            }
            else
            {
                var result = new DateTime(today.Ticks - birthday.Ticks);
                return $"Вам {result.Year - 1} лет, {result.Month - 1} месяцев, {result.Day - 1} дней";
            }
        }

        public string CalcAge(int day, int month, int year, int heDay, int heMonth, int heYear)
        {
            var birthday = new DateTime(year, month, day);
            var today = new DateTime(heYear, heMonth, heDay);

            if (now.Ticks < birthday.Ticks)
            {
                throw new Exception("You haven't been born yet");
            }
            else
            {
                var res = new DateTime(today.Ticks - birthday.Ticks);
                return $"Вам {res.Year - 1} лет, {res.Month - 1} месяцев, {res.Day - 1} дней";
            }
        }
    }
}