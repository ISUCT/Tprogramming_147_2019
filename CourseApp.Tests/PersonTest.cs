using System;
using Xunit;

namespace CourseApp.Tests
{
    public class PersonTest
    {
        [Fact]
        public void TestConstructor()
        {
            var item = new Person();
            Assert.Equal(18, item.Age);
            Assert.Equal("Name", item.Name);
            Assert.Equal("LastName", item.LastName);
        }

        [Fact]
        public void TestSetAge()
        {
            var item = new Person();
            item.Age = 30;
            Assert.Equal(30, item.Age);
        }

        [Fact]
        public void TestIncorrectSetAge()
        {
            try
            {
                var item = new Person();
                item.Age = -1000;
            }
            catch (System.Exception)
            {
                Console.WriteLine("Age should be more 0 and less than 100");
                Assert.True(true);
            }
        }

        [Fact]
        public void TestCorrectIncorrectSetAge()
        {
            var item = new Person();
            item.Age = 27;
            try
            {
                item.Age = -1;
            }
            catch
            {
                Assert.Equal(27, item.Age);
                return;
            }

            Assert.Equal(27, item.Age);
        }

        [Fact]
        public void TestIncorrectSetString()
        {
            var item = new Person();
            item.Name = string.Empty;
            item.LastName = string.Empty;
            Assert.Equal(string.Empty, item.Name);
            Assert.Equal(string.Empty, item.LastName);
        }

        [Fact]
        public void TestCorrectSetString()
        {
            var item = new Person();
            item.Name = "VikiVik";
            item.LastName = "Moro";
            Assert.Equal("VikiVik", item.Name);
            Assert.Equal("Moro", item.LastName);
        }
    }
}
