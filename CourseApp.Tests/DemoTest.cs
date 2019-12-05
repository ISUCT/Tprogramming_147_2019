using System;
using Xunit;

namespace CourseApp.Tests
{
    public class DemoTest
    {
         [Theory]
        [InlineData(0, 0, double.NaN)]
        [InlineData(0, 1, double.PositiveInfinity)]
        [InlineData(1, 2, 1.344)]
        public void TestCalc(double a, double x, double exp)
        {
            var res = Program.MyFunction(a, x);
            Assert.Equal(exp, res, 3);
        }

        [Fact]
        public void TestNormalA()
        {
            var exp = Program.TaskA(2.25, 1.2, 2.7, 0.3);
            var act = new double[] { 3.0103344159677916, 3.6097497543328076, 6.652145016692401, 16.161815341705136, 47.58859115830112, 164.15211982561777 };
            for (int i = 0; i < 5; i++)
            {
            Assert.Equal(exp[i], act[i], 3);
            }
        }

        [Fact]
        public void TestNormalB()
        {
            var x = new double[] { 1.31, 1.39, 1.44, 1.56, 1.92 };
            var act = Program.TaskB(2, x);
            var exp = new double[] { 2.8713304537946596, 2.9552006807606412, 3.0576161138202966, 3.4685781677040985, 6.838984170495196 };
            for (int i = 0; i < 5; i++)
            {
                Assert.Equal(exp[i], act[i], 3);
            }
        }

        [Fact]
        public void TestIfNoB()
        {
            var res = Program.TaskB(0, new double[0]);
            Assert.Empty(res);
        }
    }
}
