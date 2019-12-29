using System;
using Xunit;

namespace CourseApp.Tests
{
    public class PersonTest
    {
        [Fact]
        public void TestConstructorStudent()
        {
            var item = new Student();
            Assert.Equal(18, item.Age);
            Assert.Equal("Name", item.Name);
            Assert.Equal("LastName", item.LastName);
            Assert.True(item.IsMale);
            Assert.True(item.Starvation);
        }

        [Fact]
        public void TestConstructorChildren()
        {
            var item = new Children();
            Assert.Equal(1, item.Age);
            Assert.Equal("Name", item.Name);
            Assert.Equal("LastName", item.LastName);
            Assert.True(item.IsMale);
            Assert.False(item.Happy);
        }

        [Fact]
        public void TestSetAgeChildren()
        {
            var item = new Children();
            item.Age = 9;
            Assert.Equal(9, item.Age);
        }

        [Fact]
        public void TestSetAgeStudent()
        {
            var item = new Student();
            item.Age = 20;
            Assert.Equal(20, item.Age);
        }

        [Fact]
        public void TestIncorrectSetAgeChildren()
        {
            try
            {
                var item = new Children();
                item.Age = -1000;
            }
            catch (System.Exception)
            {
                Console.WriteLine("Age should be more 0 and less than 12");
                Assert.True(true);
            }
        }

        [Fact]
        public void TestCorrectIncorrectSetAge()
        {
            var item = new Student();
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
    }
}