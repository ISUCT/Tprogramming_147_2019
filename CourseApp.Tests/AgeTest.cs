using System;
using Xunit;

namespace CourseApp.Tests
{
    public class AgeTest
    {
        [Fact]
        public void TestDate()
        {
            Assert.Equal("Вам 19 лет, 9 месяцев и 2 дня", AgeClass.Age(25, 3, 2000));
        }

        [Fact]
        public void TodayBirthdayTest()
        {
            Assert.Equal("Вам 0 лет, 0 месяцев и 0 дня", AgeClass.Age(DateTime.Now.Day, DateTime.Now.Month, DateTime.Now.Year));
        }

        [Fact]
        public void BirthdayAboveToday()
        {
            try
            {
                AgeClass.Age(16, 8, 2048);
                Assert.True(false);
            }
            catch
            {
                Console.WriteLine("Birthday > Today");
                Assert.True(true);
            }
        }
    }
}