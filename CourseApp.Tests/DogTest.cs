using System;
using Xunit;

namespace CourseApp.Tests
{
    public class DogTest
    {
        [Fact]
        public void TestConstructor()
        {
            var item = new Dog();
            Assert.Equal(1, item.Age);
            Assert.Equal("Test", item.Name);
            Assert.Equal("male", item.Sex);
        }

        [Fact]
        public void TestSetAge()
        {
            var item = new Dog();
            item.Age = 3;
            Assert.Equal(3, item.Age);
        }

        [Fact]
        public void TestWrongAge()
        {
        var item = new Dog();
        try
            {
                item.Age = 0;
            }
        catch (System.Exception)
            {
                Console.WriteLine("ERROR! Rewrite Age!");
                Assert.True(true);
            }
        }

        [Fact]
        public void TestWrongSex()
        {
        var item = new Dog();
        try
            {
                item.Sex = "lemonade";
            }
        catch (System.Exception)
            {
                Console.WriteLine("ERROR! Rewrite Sex!");
                Assert.True(true);
            }
        }

        [Fact]
        public void FullTest()
        {
            var item = new Dog("Doberman", 3, "male");
            Assert.Equal("Doberman", item.Name);
            Assert.Equal("male", item.Sex);
            Assert.Equal(3, item.Age);
        }
    }
}