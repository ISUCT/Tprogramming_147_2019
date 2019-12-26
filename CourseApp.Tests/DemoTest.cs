using System;
using System.Collections.Generic;
using Xunit;

namespace CourseApp.Tests
{
    public class DemoTest
    {
        [Theory]
        [InlineData(2.5, 4.6, 0.5, 79.894)]
        [InlineData(1, 1, 2, 3.83)]
        [InlineData(-1, 1, 1, 0)]
        public void TestCalc(double a, double b, double x, double exp)
        {
            var res = Program.MyFunction(a, b, x);
            Assert.Equal(exp, res, 3);
        }

        [Fact]
        public void TestNormalA()
        {
            var res = Program.TaskA(1, 2, 3, 4, 1);
            var len = res.Count;
            Assert.Equal(1, len);
        }

        [Fact]
        public void TestNormalB()
        {
           var xB = new List<double> { 1.2, 1.28, 1.36, 1.46, 2.35 };
           var res = Program.TaskB(0.3, 1, xB);
            var len = res.Count;
            Assert.Equal(5, len);
        }

        [Fact]
        public void TestZeroLengthB()
        {
            var res = Program.TaskB(1, 1, new List<double>());
            Assert.Empty(res);
        }
    }
}