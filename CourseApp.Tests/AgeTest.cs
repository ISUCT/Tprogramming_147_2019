using System;
using Xunit;

namespace CourseApp.Tests
{
    public class AgeTest
    {
        [Fact]
        public void TestNormalDate()
        {
            var result = new DateTime(DateTime.Now.Ticks - new DateTime(1998, 08, 04).Ticks);
            Assert.Equal($"Вам {result.Year - 1} лет, {result.Month - 1} месяцев и {result.Day - 2} дня", AgeClass.Age(04, 08, 1998));
        }

        [Fact]
        public void TestTodayBirthday()
        {
            try
            {
                Assert.Equal(0, DateTime.Compare(DateTime.Now, AgeClass.DateCompare(DateTime.Now, DateTime.Now)));
            }
            catch (Exception)
            {
                Console.WriteLine("Понимаю, только родился");
            }
        }

        [Fact]
        public void BirthdayAboveToday()
        {
            try
            {
                Assert.Equal(0, DateTime.Compare(DateTime.Now, AgeClass.DateCompare(DateTime.Now, new DateTime(2048, 8, 16))));
            }
            catch (Exception)
            {
                Console.WriteLine("Добро пожаловать в прошлое");
            }
        }
    }
}
