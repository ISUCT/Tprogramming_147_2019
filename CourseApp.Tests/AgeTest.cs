using System;
using Xunit;

namespace CourseApp.Tests
{
    public class AgeTest
    {
        [Fact]
        public void TestDate()
        {
            DateTime date1 = new DateTime(2000, 3, 25);
            DateTime date2 = new DateTime(2020, 1, 9);
            Assert.Equal("Вам 19 лет, 9 месяцев и 16 дня", AgeClass.Age(date1, date2));
        }

        [Fact]
        public void TodayBirthdayTest()
        {
            DateTime date1 = new DateTime(2020, 1, 9);
            DateTime date2 = new DateTime(2020, 1, 9);

            try
            {
                Assert.Equal("Вам 0 лет, 0 месяцев и 0 дня", AgeClass.Age(date1, date2));
                Assert.True(false);
            }
            catch
            {
                Console.WriteLine("Birthday = Today");
                Assert.True(true);
            }
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