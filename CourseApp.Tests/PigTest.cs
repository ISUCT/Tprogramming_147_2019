using System;
using Xunit;

namespace CourseApp.Tests
{
    public class PigTest
    {
        [Fact]
        public void TestEmptyConstructor()
        {
            var item = new Pig();
            Assert.Equal(1, item.Age);
            Assert.Equal("Test", item.Name);
            Assert.Equal(1, item.Salo);
            Assert.Equal("male", item.Gender);
        }

        [Theory]
        [InlineData("PigMan", 5, 7,"male")]
        [InlineData("PigGirl", 2, 1,"female")]
        [InlineData("PigPigger", 10, 11,"male")]
        public void TestFullConstructor(string name, int age, int salo, string gender)
        {
            var item = new Pig(name, age, salo, gender);
            Assert.Equal(age, item.Age);
            Assert.Equal(name, item.Name);
            Assert.Equal(salo, item.Salo);
            Assert.Equal(gender, item.Gender);
        }

        [Fact]
        public void TestRightSetAge()
        {
            var item = new Pig();
            item.Age = 11;
            Assert.Equal(11, item.Age);
        }

        [Fact]
        public void TestWrongSetAge()
        {
            try
            {
                var item = new Pig();
                item.Age = -1000;
            }
            catch (System.Exception)
            {
                Console.WriteLine("Возраст должен быть больше 1 года");
                Assert.True(true);
            }       
        }
    }
}