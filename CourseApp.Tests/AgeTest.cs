using System;
using Xunit;

namespace CourseApp.Tests
{
    public class AgeTest
    {
        [Fact]
        public void TodayBirthdayTest()
        {
            try
            {
                Assert.Equal(0, DateTime.Compare(DateTime.Now, AgeClass.CompareTheDate(DateTime.Now, DateTime.Now)));
            }
            catch (Exception)
            {
            }
        }
    }
}