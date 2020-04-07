using System;
using Xunit;

namespace CourseApp.Tests
{
    public class IntefacesTest
    {
        [Fact]
        public void Test1()
        {
            Assert.True(true);
        }

        [Fact]
        public void Icloneable()
        {
            Person person1 = new Student("Аля", "Сомова", 18, false, false);
            Person person2 = (Person)person1.Clone();
            person2.Name = "Юрий";
            person2.LastName = "Гагарин";
            person2.IsMale = true;
            person2.Age = 21;
            Assert.Equal(18, person1.Age);
            Assert.Equal("Аля", person1.Name);
            Assert.Equal("Сомова", person1.LastName);
            Assert.False(person1.IsMale);
            Assert.Equal(21, person2.Age);
            Assert.Equal("Юрий", person2.Name);
            Assert.Equal("Гагарин", person2.LastName);
            Assert.True(person2.IsMale);
        }

        [Fact]
        public void IComparable()
        {
            Person[] mass = new Person[3];
            mass[0] = new Children("Name2", "LastName1", 10, false, true);
            mass[1] = new Children("Name1", "LastName2", 7, false, true);
            mass[2] = new Children("Name3", "LastName3", 8, false, true);
            Array.Sort(mass);
            Assert.Equal("Name1", mass[0].Name);
            Assert.Equal("Name3", mass[1].Name);
            Assert.Equal("Name2", mass[2].Name);
        }
    }
}