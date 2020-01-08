using System;
using Xunit;

namespace CourseApp.Tests
{
    public class AnimalsTest
    {
        [Fact]
        public void TestConstructorMouse()
        {
            var item = new Mouse();
            Assert.Equal(1, item.Age);
            Assert.Equal("Неизвестно", item.Name);
            Assert.True(item.IsMale);
            Assert.False(item.Aggression);
        }

        [Fact]
        public void TestConstructorCat()
        {
            var item = new Cat();
            Assert.Equal(1, item.Age);
            Assert.Equal("Неизвестно", item.Name);
            Assert.True(item.Brood);
            Assert.False(item.IsMale);
        }

        [Fact]
        public void TestSetAgeCat()
        {
            var item = new Cat();
            item.Age = 9;
            Assert.Equal(9, item.Age);
        }

        [Fact]
        public void TestSetAgeMouse()
        {
            var item = new Mouse();
            item.Age = 2;
            Assert.Equal(2, item.Age);
        }

        [Fact]
        public void TestIncorrectSetAgeCat()
        {
            try
            {
                var item = new Mouse();
                item.Age = -1000;
            }
            catch (System.Exception)
            {
                Console.WriteLine("Age should be > 0 and < than 3");
                Assert.True(true);
            }
        }

        [Fact]
        public void TestCorrectIncorrectSetAge()
        {
            var item = new Cat();
            item.Age = 7;
            try
            {
                item.Age = -1;
            }
            catch
            {
                Assert.Equal(7, item.Age);
                return;
            }

            Assert.Equal(7, item.Age);
        }
    }
}