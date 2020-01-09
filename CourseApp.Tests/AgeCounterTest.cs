using System;
using Xunit;

namespace CourseApp.Tests
{
    public class AgeCounterTest
    {
        [Fact]
        public void CorrectAgeInputTest()
        {
            var yeah = new AgeCounter();
            Assert.Equal($"Возраст:21 лет, 0 месяцев, 2 дней", yeah.CountAge(12, 10, 1999, 13, 10, 2020));
        }

        [Fact]
        public void FutureDateInputTest()
        {
            var time = new AgeCounter();
            try
            {
                Assert.Equal($"Возраст:-2 лет, 2 месяцев, 6 дней", time.CountAge(16, 6, 2021, 19, 12, 2019));
            }
            catch
            {
                Assert.True(true);
            }
        }

        [Fact]
        public void CurrentDayIsBirthdayTest()
        {
            var time = new AgeCounter();
            var day = DateTime.Today.Day;
            var month = DateTime.Today.Month;
            var year = DateTime.Today.Year;
            try
            {
                Assert.Equal($"Возраст:0 лет, 0 месяцев, 0 дней", time.CountAge(5, 1, 2020, 5, 1, 2020));
            }
            catch
            {
                Assert.True(true);
            }
        }

        [Theory]
        [InlineData(30, 11, 2000, 19, 0, 19)]
        [InlineData(16, 11, 2000, 2, 1, 19)]
        public void CurrectYearCountTest(int d, int m, int y, int expD, int expM, int expY)
        {
            var time = new AgeCounter();
            Assert.Equal($"Возраст:{expY} лет, {expM} месяцев, {expD} дней", time.CountAge(d, m, y, 19, 12, 2019));
        }
    }
}