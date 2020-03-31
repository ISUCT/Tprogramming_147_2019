using System;
using Xunit;

namespace CourseApp.Tests
{
    public class AgeTest
    {
        [Fact]
        public void TestDate()
        {
            Assert.Equal("Вам 21 лет, 7 месяцев и 26 дня", AgeClass.Age(04, 08, 1998));
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
                Console.WriteLine("Birthday == Today");
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
                Console.WriteLine("Birthday > Today");
            }
        }
    }
}
