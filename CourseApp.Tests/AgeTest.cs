using System;
using Xunit;

namespace CourseApp.Tests
{
    public class AgeTest
    {
    [Fact]
    public void TestAge()
    {
        DateTime birthday = new DateTime(2000, 8, 21);
        DateTime exp = new DateTime(DateTime.Now.Ticks - birthday.Ticks);
        Assert.Equal($"Вам {exp.Year - 1} лет, {exp.Month - 1} месяцев и {exp.Day - 1} дня", AgeClass.Age(birthday));
    }

    [Fact]
    public void TestBirthdayAboveToday()
        {
            try
            {
                AgeClass.Age(new DateTime(2056, 2, 12));
            }
            catch (Exception)
            {
                Console.WriteLine("Birthday > Today");
                Assert.True(true);
            }
    }

    [Fact]
    public void TestBirthdayToday()
    {
        Assert.Equal("Вам 0 лет, 0 месяцев и 0 дня", AgeClass.Age(DateTime.Now));
    }
    }
}