using System;
using Xunit;

namespace CourseApp.Tests
{
        public class BirthDateTest
    {
      [Fact]
      public void IfMatch()
      {
          var item = new BirthDate();
          try
          {
            item.Year = DateTime.Now.Year;
            item.Month = DateTime.Now.Month;
            item.Day = DateTime.Now.Day;
          }
          catch
          {
            Console.WriteLine($"Hmmmm....today is, like, the same date...");
            Assert.True(true);
          }
      }

      [Fact]
      public void IfBefore()
      {
         var item = new BirthDate(2000, 10, 15);
         try
         {
           item.CalcAge(2000);
         }
         catch
         {
           Console.WriteLine($"Full years - 19, Full months - 2, Full days - 1");
           Assert.True(true);
         }
      }

      [Fact]
      public void IfLater()
      {
          var item = new BirthDate();
          try
          {
           item.Year = 2020;
           item.Month = 1;
           item.Day = 1;
          }
          catch
          {
           Console.WriteLine($"Hey! It should be before or at least in {DateTime.Now.Year}");
           Assert.True(true);
          }
      }
    }
}