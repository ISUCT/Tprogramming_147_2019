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
            Assert.Equal("Test", item.Name);
            Assert.Equal(1, item.Age);
            Assert.Equal(1, item.Salo);
            Assert.Equal("Male", item.Gender);
        }

        [Theory]
        [InlineData("PigMale", 5, 7, "Male")]
        [InlineData("PigFemale", 2, 1, "Female")]
        [InlineData("PigPigger", 10, 11, "Male")]
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
                item.Age = -100;
            }
            catch (System.Exception)
            {
                Console.WriteLine("Возраст должен быть больше 1 года");
                Assert.True(true);
            }
        }
    }
}
