using System;
using Xunit;

namespace CourseApp.Tests
{
    public class AutoTest
    {
        [Fact]
        public void TestEmptyConstructor()
        {
            var item = new Auto();
            Assert.Equal(60, item.Speed);
            Assert.Equal("Untitled", item.Name);
            Assert.Equal(2000, item.Year);
        }

        [Fact]
        public void TestSetSpeed()
        {
            var item = new Auto();
            item.Speed = 75;
            Assert.Equal(75, item.Speed);
        }

        [Fact]
        public void TestIncorrectSetSpeed()
        {
            var item = new Auto();
            try
            {
                item.Speed = -1000;
            }
            catch (System.Exception)
            {
                Console.WriteLine("Speed should be more 0 and less than 300");
                Assert.True(true);
            }

            Assert.Equal(60, item.Speed);
        }

        [Fact]
        public void TestCorrectIncorrectSetSpeed()
        {
            var item = new Auto();
            item.Speed = 100;
            try
            {
                item.Speed = -10;
            }
            catch
            {
                Assert.Equal(100, item.Speed);
            }

            Assert.Equal(100, item.Speed);
        }

        [Fact]
        public void TestIncorrectSetName()
        {
            var item = new Auto();
            item.Name = string.Empty;
            Assert.Equal(string.Empty, item.Name);
        }

        [Fact]
        public void TestCorrectSetName()
        {
            var item = new Auto();
            item.Name = "Mercedes Benz";
            Assert.Equal("Mercedes Benz", item.Name);
        }

        [Fact]
        public void TestSetYear()
        {
            var item = new Auto();
            item.Year = 1972;
            Assert.Equal(1972, item.Year);
        }

        [Fact]
        public void TestSetColor()
        {
            var item = new Auto();
            item.Color = "white";
            Assert.Equal("white", item.Color);
        }

        [Fact]
        public void TestIncorrectSetColor()
        {
            var item = new Auto();

            try
            {
                item.Color = "blue";
            }
            catch (System.Exception)
            {
                Assert.True(true);
            }
        }

        [Fact]
        public void TestOverride()
        {
            var item = new Auto();
            Assert.Equal("The black car Untitled(2000) is moving at a speed of 60 km/h.", item.ToString());
            Assert.Equal("This car is 20 years old.", item.Info());
        }
    }
}