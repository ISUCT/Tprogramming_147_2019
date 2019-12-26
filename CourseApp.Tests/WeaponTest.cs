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
    }
}