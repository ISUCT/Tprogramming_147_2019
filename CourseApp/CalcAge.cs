using System;

namespace CourseApp
{
    public class CalcAge
    {
        private DateTime now = DateTime.Today;

        public string CalculateAge(int day, int month, int year, bool fullAge)
        {
            var birthday = new DateTime(year, month, day);
            var today = DateTime.Today;

            if (birthday.Ticks > now.Ticks)
            {
                throw new Exception("you cannot enter a date that did not occur");
            }
            else if (birthday.Ticks == now.Ticks)
            {
                throw new Exception("he/she/you was born today");
            }
            else
            {
                var age = new DateTime(today.Ticks - birthday.Ticks);
                if (fullAge == true)
                {
                    return $"Возраст:{age.Year - 1} лет, {age.Month - 1} месяцев, {age.Day - 1} дней";
                }
                else
                {
                    return $"Возраст:{age.Year - 1} лет";
                }
            }
        }

        public string CalculateAge(int day, int month, int year, int currDay, int currMonth, int currYear, bool fullAge)
        {
            var birthday = new DateTime(year, month, day);
            var today = new DateTime(currYear, currMonth, currDay);

            if (birthday.Ticks > now.Ticks)
            {
                throw new Exception("you cannot enter a date that did not occur");
            }
            else if (birthday.Ticks == now.Ticks)
            {
                throw new Exception("he/she/you was born today");
            }
            else
            {
                var age = new DateTime(today.Ticks - birthday.Ticks);
                if (fullAge == true)
                {
                    return $"Возраст:{age.Year - 1} лет, {age.Month - 1} месяцев, {age.Day - 1} дней";
                }
                else
                {
                    return $"Возраст:{age.Year - 1} лет";
                }
            }
        }
    }
}
