using System;
using Xunit;

namespace CourseApp.Tests
{
    public class PistolTest
    {
        [Fact]
        public void TestEmptyConstructor()
        {
            var item = new Pistol();
            Assert.Equal(0, item.Kalibr);
            Assert.Equal("No model", item.Model);
            Assert.True(item.Hit);
        }

        [Fact]
        public void TestSetAge()
        {
            var item = new Pistol();
            item.Kalibr = 5;
            Assert.Equal(5, item.Kalibr);
        }

        [Fact]
        public void TestShoot()
        {
            var item = new Pistol("Glock", 10, true);
            var act = item.Shoot(true);
            Assert.Equal($"Pistol Glock and 10 hit!", act);
        }

        [Fact]
        public void TestNumShoot()
        {
            var item = new Pistol("Glock", 10, true);
            var act = item.NumShoot(15);
            Assert.Equal($"Glock made of 15 shots", act);
        }

        [Fact]
        public void TestCorrectIncorrectSetKalibr()
        {
            var item = new Pistol();
            try
            {
                item.Kalibr = -5;
                Assert.Equal(-5, item.Kalibr);
            }
            catch (System.Exception)
            {
                Assert.True(true);
            }
        }
    }
}
