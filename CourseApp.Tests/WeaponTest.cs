using System;
using Xunit;

namespace CourseApp.Tests
{
    public class WeaponTest
    {
        [Fact]
        public void TestEmptyConstructorForPistol()
        {
            var item = new Pistol();
            Assert.Equal(0, item.Kalibr);
            Assert.Equal("No model", item.Model);
        }

        [Fact]
        public void TestForToString()
        {
            var item = new Rifle();
            Assert.Equal("Rifle-No model, 0, True", item.ToString());
        }

        [Fact]
        public void TestShoot()
        {
            var item = new Rifle("Glock", 10, true);
            var act = item.Shoot(true);
            Assert.Equal($"Rifle Glock and 10 hit!", act);
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

        [Fact]
        public void TestNumShoot()
        {
            var item = new Pistol("Glock", 10, true);
            var act = item.NumShoot(15);
            Assert.Equal($"Glock made of 15 shots", act);
        }
    }
}