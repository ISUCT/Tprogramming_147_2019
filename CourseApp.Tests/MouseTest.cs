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
        public void TestConstructor()
        {
            var item = new Mouse("Rat", 2, false);
            Assert.Equal(2, item.Age);
            Assert.Equal("Rat", item.Name);
            Assert.False(item.IsMale);
        }

        [Fact]
        public void TestSetAge()
        {
            var item = new Mouse();
            item.Age = 2;
            Assert.Equal(2, item.Age);
        }

        [Fact]
        public void TestIncorrectSetAge()
        {
            var item = new Mouse();
            item.Age = -5;
            Assert.Equal(0, item.Age);
        }

        [Fact]
        public void TestCorrectIncorrectSetAge()
        {
            var item = new Mouse();
            item.Age = 2;
            item.Age = -5;
            Assert.Equal(2, item.Age);
        }
    }
}