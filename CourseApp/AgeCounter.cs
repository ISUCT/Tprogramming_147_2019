using System;

namespace CourseApp
{
    public class AgeCounter
    {
        private DateTime now = DateTime.Today;

        public string CountAge(int day, int month, int year)
        {
            var birthday = new DateTime(year, month, day);
            var today = DateTime.Today;

            if (birthday.Ticks > now.Ticks)
            {
                throw new Exception("плохая дата;)");
            }
            else if (birthday.Ticks == now.Ticks)
            {
                throw new Exception("нельзя вводить текущую дату");
            }
            else
            {
                var age = new DateTime(today.Ticks - birthday.Ticks);

                return $"Возраст:{age.Year - 1} лет, {age.Month - 1} месяцев, {age.Day - 1} дней";
            }
        }

        public string CountAge(int day, int month, int year, int nowDay, int nowMonth, int nowYear)
        {
            var birthday = new DateTime(year, month, day);
            var today = new DateTime(nowYear, nowMonth, nowDay);

            if (birthday.Ticks > now.Ticks)
            {
                throw new Exception("плохая дата;)");
            }
            else if (birthday.Ticks == now.Ticks)
            {
                throw new Exception("нельзя вводить текущую дату");
            }
            else
            {
                var age = new DateTime(today.Ticks - birthday.Ticks);

                return $"Возраст:{age.Year - 1} лет, {age.Month - 1} месяцев, {age.Day - 1} дней";
            }
        }
    }
}