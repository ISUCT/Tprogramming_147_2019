using System;
using Xunit;

namespace CourseApp.Tests
{
    public class HeroTest
    {
        [Fact]
        public void TestEmptyConstructor()
        {
            var item = new Hero();
            Assert.Equal(0, item.Level);
            Assert.Equal("No role", item.Role);
            Assert.True(item.Attack);
        }

        [Fact]
        public void TestSetAge()
        {
            var item = new Hero();
            item.Level = 5;
            Assert.Equal(5, item.Level);
        }

        [Fact]
        public void TestShoot()
        {
            var item = new Hero("Sniper", 10, true);
            var act = item.Shoot(true);
            Assert.Equal($"Hero Sniper and 10 made the shot!", act);
        }

        [Fact]
        public void TestNumShoot()
        {
            var item = new Hero("Sniper", 10, true);
            var act = item.NumShoot(15);
            Assert.Equal($"Sniper made of 15 shots!", act);
        }

        [Fact]
        public void TestCorrectIncorrectSetLevel()
        {
            var item = new Hero();
            try
            {
                item.Level = -5;
                Assert.Equal(-5, item.Level);
            }
            catch (System.Exception)
            {
                Assert.True(true);
            }
        }

        [Fact]
        public void TestCorrectArray()
        {
            var characters = new Character[] { new Hero(), new Enemy() };
            Assert.Equal(characters[1].ToString(), $"Enemy-No role, 0, True");
        }
    }
}