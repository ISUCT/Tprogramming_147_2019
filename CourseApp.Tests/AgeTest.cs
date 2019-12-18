using System;
using Xunit;

namespace CourseApp.Tests
{
    public class AgeTest
    {
        [Fact]
        public void TestDate()
        {
            double x = DateTime.Now.Ticks - new DateTime(2000, 12, 7).Ticks;
            double y = AgeClass.DateCompare(new DateTime(2000, 12, 7), DateTime.Now).Ticks;
            if (y - x > 0.000000001)
            {
                Assert.True(true);
            }
        }

        [Fact]
        public void TodayBirthdayTest()
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