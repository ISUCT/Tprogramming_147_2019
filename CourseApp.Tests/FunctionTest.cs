using System;
using Xunit;

namespace CourseApp.Tests
{
    public class FunctionTest
    {
        [Theory]
        [InlineData( 0, 0, double.NaN)]
        [InlineData( 1, 2, 2.5)]
        [InlineData( -1, 1, 0)]
        public void TestCalc(double x, double exp)
        {
            var res = Program.MyFunction(x);
            Assert.Equal(exp, res, 1);
        }

        [Fact]
        public void TestNormalA()
        {
        }

        [Fact]
        public void TestNormalB()
        {
        }

        [Fact]
        public void TestZeroLengthB()
        {
            var res = Program.TaskB(new double[0]);
            Assert.Empty(res);
        }
    }
}
