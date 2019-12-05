using System;
using System.Collections.Generic;
using Xunit;

namespace CourseApp.Tests
{
    public class DemoTest
    {
        [Theory]
        [InlineData(2.6, 4.7, 0.5, double.NaN)]
        [InlineData(1, 1, 2, double.NaN)]
        [InlineData(-1, 1, 1, double.PositiveInfinity)]
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
            var xB = new List<double> { 0.15, 0.26, 0.37, 0.48, 0.53 };
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
