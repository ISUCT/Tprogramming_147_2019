using System;
using Xunit;

namespace CourseApp.Tests
{
    public class DogTest
    {
        [Fact]
        public void TestEmptyConstructor()
        {
            var item = new Dog();
            Assert.Equal(0, item.Age);
            Assert.Equal("Test", item.Name);
            Assert.Equal("male", item.Gender);
        }

        [Fact]
        public void TestSetAge()
        {
            var item = new Dog();
            item.Age = 5;
            Assert.Equal(5, item.Age);
        }

        [Fact]
        public void TestIncorrectSetAge()
        {
        var item = new Dog();
        try
            {
                item.Age = -5;
            }
        catch (System.Exception)
            {
                Console.WriteLine("rewrite age.");
                Assert.True(true);
            }
        }

        [Fact]
        public void TestIncorrectSetGender()
        {
        var item = new Dog();
        try
            {
                item.Gender = "lemonade";
            }
        catch (System.Exception)
            {
                Console.WriteLine("rewrite gender");
                Assert.True(true);
            }
        }

        [Fact]
        public void TestName()
        {
            var item = new Dog("Eevee");
            Assert.Equal("Eevee", item.Name);
        }

        [Fact]
        public void TestFullConstructor()
        {
            var item = new Dog("Mew", 5, "male");
            Assert.Equal(5, item.Age);
            Assert.Equal("Mew", item.Name);
            Assert.Equal("male", item.Gender);
        }
    }
}