using System;
using Xunit;

// using CourseApp.Program;
namespace CourseApp.Tests
{
    public class DemoTest
    {
        [Theory]
        [InlineData(0, 0, double.NaN)]
        [InlineData(-1, 0, 1)]
        [InlineData(2, 10, 6)]

        public void TestCalc(double a, double x, double exp)
        {
            var res = Program.MyFunction(a, x);
            Assert.Equal(exp, res, 3);
        }

        [Fact]

        public void TestNotANumber()
        {
            var a = Program.MyFunction(1, 1);
            Assert.True(double.IsNaN(a));
        }

        [Fact]
        public void TestNormalA()
        {
            var a = Program.MyFunction(, 0);

        }

        [Fact]
        public void TestNormalB()
        {
        }

        [Fact]
        public void TestZeroLengthB()
        {
            var res = Program.TaskB(0, new double[0]);
            Assert.Empty(res);
        }
    }
}
