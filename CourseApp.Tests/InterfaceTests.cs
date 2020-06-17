using System;
using System.Collections.Generic;
using Xunit;

namespace CourseApp.Tests
{
    public class InterfaceTests
    {
        [Fact]
        public void Test1()
        {
            Assert.True(true);
        }

        [Fact]
        public void IComparable()
        {
            Animal[] mass = new Animal[3];
            mass[0] = new Cat("Name1", 6, true, true);
            mass[1] = new Mouse("Name2", 1, false, true);
            mass[2] = new Cat("Name3", 3, false, true);
            Array.Sort(mass);
            Assert.Equal("Name2", mass[0].Name);
            Assert.Equal("Name3", mass[1].Name);
            Assert.Equal("Name1", mass[2].Name);
        }
    }
}