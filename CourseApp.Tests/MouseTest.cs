using System;
using Xunit;

namespace CourseApp.Tests
{
    public class MouseTest
    {
        [Fact]
        public void TestEmptyConstructor()
        {
            var item = new Mouse();
            Assert.Equal(0, item.Age);
            Assert.Equal("Untitled", item.Name);
            Assert.True(item.IsMale);
        }

        [Fact]
        public void TestView()
        {
            var item = new Mouse();
            var view = "```оО````\n ```•._)~``\n ``````````";
            Assert.Equal(view, item.View());
        }

        [Fact]
        public void TestSetAge()
        {
            var item = new Mouse();
            item.Age = 5;
            Assert.Equal(5, item.Age);
        }

        [Fact]
        public void TestIncorrectSetAge()
        {
            var item = new Mouse();
            try
            {
                item.Age = -5;
            }
            catch (System.Exception)
            {
                Assert.True(true);
            }

            Assert.Equal(0, item.Age);
        }

        [Fact]
        public void TestPeep()
        {
            var item = new Mouse();
            Assert.Equal("Mouse squeaks.", item.Peep());
        }

        [Fact]
        public void TestToString()
        {
            var item = new Mouse();
            Assert.Equal("The mouse's name is Untitled.He is 0 years old.", item.ToString());
            item.IsMale = false;
            Assert.Equal("The mouse's name is Untitled.She is 0 years old.", item.ToString());
        }
    }
}
