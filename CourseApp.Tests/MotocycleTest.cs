using System;
using Xunit;

namespace CourseApp.Tests
{
    public class MotocycleTest
    {
        [Fact]
        public void TestConstructor()
        {
            var item = new Motocycle("harley davidson", 2000, 60, 300);
            Assert.Equal(2000, item.Year);
            Assert.Equal(60, item.Speed);
            Assert.Equal("harley davidson", item.Name);
            Assert.Equal(300, item.Power);
        }

        [Fact]
        public void TestSetSpeed()
        {
            var item = new Motocycle();
            item.Speed = 30;
            Assert.Equal(30, item.Speed);
        }

        [Fact]
        public void TestIncorrectSetSpeed()
        {
            var item = new Motocycle();
            try
            {
                item.Speed = -1;
            }
            catch (System.Exception)
            {
                Console.WriteLine("Speed should be more 0 and less than 300");
                Assert.True(true);
            }

            Assert.Equal(40, item.Speed);
        }

        [Fact]
        public void TestIncorrectSetPower()
        {
            var item = new Motocycle();

            try
            {
                item.Power = -10;
            }
            catch (System.Exception)
            {
                Assert.True(true);
            }
        }

        [Fact]
        public void TestOverride()
        {
            var item = new Motocycle();
            Assert.Equal("The motorcycle has a capacity of 100 horsepower.", item.Info());
            Assert.Equal("The motocycle Untitled(1999) is moving at a speed of 40 km/h.", item.ToString());
        }
    }
}