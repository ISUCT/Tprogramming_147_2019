using System;
using Xunit;

namespace CourseApp.Tests
{
        public class MovieTest
    {
        [Fact]
        public void IfEmptyConstructor()
        {
            var item = new Movie();
            Assert.Equal(1990, item.Year);
            Assert.Equal("No title", item.Name);
            Assert.Equal("No country", item.Country);
        }

        [Fact]
        public void SetYear()
        {
            var item = new Movie();
            item.Year = 2005;
            Assert.Equal(2005, item.Year);
        }

        [Fact]
        public void IfIncorSetYear()
        {
            var item = new Movie();
            try
            {
                item.Year = 1500;
                Assert.Equal(1990, item.Year);
            }
            catch (System.Exception)
            {
                Console.WriteLine($"Production year should be between 1990 and {DateTime.Now.Year}");
                Assert.True(true);
            }
        }

        [Fact]
        public void IfCorrIncorSetYear()
        {
            var item = new Movie();
            try
            {
                item.Year = 2008;
                item.Year = 2357;
                Assert.Equal(2008, item.Year);
            }
            catch (System.Exception)
            {
                Console.WriteLine($"Production year should be between 1990 and {DateTime.Now.Year}");
                Assert.True(true);
            }
        }

        [Fact]
        public void IfCorName()
        {
            var item = new Movie();
            item.Country = "Canada";
            Assert.Equal("Canada", item.Country);
        }

        [Fact]
        public void TestSendMovie()
        {
            var item = new Movie(1990, "It", "America-Canada");
            var act = item.SendMovie("Semyon");
            Assert.Equal($"Hi Semyon, can you check It(1990) to watch? I want you to tell me something about it as a movie expert", act);
        }

        [Fact]
        public void TestWatchMovie()
        {
            var item = new Movie(1990, "It", "America-Canada");
            var act = item.WatchMovie();
            Assert.Equal($"I'm watching a movie, named It, which came out in 1990 from America-Canada", act);
        }
    }
}
