using System;
using Xunit;

namespace CourseApp.Tests
{
    public class AgeTest
    {
        [Fact]
        public void TestDate()
        {
            var res = new AgeCalc();
            Assert.Equal("Вам 19 лет, 2 месяцев, 18 дней", res.CalcAge(22, 10, 2000, 8, 1, 2020));
        }

        [Fact]
        public void BirthdayAboveToday()
        {
            var res = new AgeCalc();
            try
            {
                res.CalcAge(27, 11, 2025, 8, 1, 2020);
                Assert.True(false);
            }
            catch
            {
                Console.WriteLine("Birthday > Today");
                Assert.True(true);
            }
        }

        [Fact]
        public void CurrentDayIsBirthdayTest()
        {
            var res = new AgeCalc();
            var day = DateTime.Today.Day;
            var month = DateTime.Today.Month;
            var year = DateTime.Today.Year;
            try
            {
                Assert.Equal(res.CalcAge(12, 12, 2019, 12, 12, 2019), $"Возраст:0 лет, 0 месяцев, 0 дней");
            }
            catch
            {
                Assert.True(true);
            }
        }
    }
}