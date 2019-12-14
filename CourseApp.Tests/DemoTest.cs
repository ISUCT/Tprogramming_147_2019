using System;
using System.Collections.Generic;
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
        public void TestZeroMass()
        {
            var res = Program.MyFunction(0.0, 0.0);
            Assert.Equal(double.NaN, res);
        }

        [Fact]
        public void TestNormalA()
        {
            double a = 2.25;
            double xn = 1.2;
            double xk = 2.7;
            double dx = 0.3;
            List<double> resA = Program.TaskA(a, xn, xk, dx);
            List<double> exp = new List<double> { 3.0103344159677916, 3.6097497543328076, 6.652145016692401, 16.161815341705136, 47.58859115830112, 164.15211982561777 };
            for (int i = 0; i < resA.Count; i++)
            {
                Assert.Equal(exp[i], resA[i], 3);
            }
        }

        [Fact]
        public void TestUnNormalA()
        {
            double a = 2;
            double xn = 1.2;
            double xk = 1.8;
            double dx = 0.1;
            List<double> resA = Program.TaskA(a, xn, xk, dx);
            List<double> exp = new List<double> { 2.93817537166978, 2.868002792075446, 2.9726167190770143, 3.232488023707175, 3.6636306128505582, 4.306161008432503 };
            for (int i = 0; i < resA.Count; i++)
            {
                Assert.Equal(exp[i], resA[i], 3);
            }
        }

        [Fact]
        public void TestNormalB()
        {
            List<double> arr = new List<double> { 1.31, 1.39, 1.44, 1.56, 1.92 };
            List<double> resB = Program.TaskB(2, arr);
            List<double> exp = new List<double> { 2.8713304537946596, 2.9552006807606412, 3.0576161138202966, 3.4685781677040985, 6.838984170495196 };
            for (int i = 0; i < 5; i++)
            {
                Assert.Equal(exp[i], resB[i], 3);
            }
        }

        [Fact]
        public void TestIfNoB()
        {
            var res = Program.TaskB(1, new List<double>());
            Assert.Empty(res);
        }
    }
}
