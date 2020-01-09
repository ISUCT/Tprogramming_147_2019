using System;

namespace CourseApp
{
    public class AgeCalc
    {
        private DateTime now = DateTime.Today;

        public string CalcAge(int day, int month, int year)
        {
            var today = DateTime.Today;
            var ageCalc = new AgeCalc();
            return ageCalc.CalcAge(day, month, year, today.Day, today.Month, today.Year);
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