using System;
using System.Collections.Generic;
using Xunit;

namespace CourseApp.Tests
{
    public class DemoTest
    {
        [Theory]
        [InlineData(0, 0, 0, double.NaN)]
        [InlineData(1, 1, 2, 2.5)]
        [InlineData(-1, 1, 1, 0)]
        public void TestCalc(double a, double b, double x, double exp)
        {
            var res = Program.MyFunction(a, b, x);
            Assert.Equal(exp, res, 3);
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
            var res = Program.TaskB(1, 1, new double[0]);
            Assert.Empty(res);
        }

        [Fact]
        public void TestNullMass()
        {
            var res = Program.MyFunction(0.0, 0.0);
            Assert.Equal(double.PositiveInfinity, res);
        }

        [Fact]
        public void TaskBWork()
        {
            List<double> arr = new List<double> { 1.02, 1.21, 1.5, 2.3, 2.71 };
            List<double> resB = Program.TaskB(2.0, arr);
            List<double> exp = new List<double> { 0.02526278072091896, 0.02489759880547166, 0.024164084643521107, 0.021702665452373534, 0.020418098612637083 };
            for (int i = 0; i < 5; i++)
            {
                Assert.Equal(exp[i], resB[i], 3);
            }
        }

        [Fact]
        public void TaskAWork()
        {
            double a = 2.0;
            double xn = 1.2;
            double xk = 4.2;
            double dx = 0.6;
            List<double> resA = Program.TaskA(a, xn, xk, dx);
            List<double> exp = new List<double> { 0.025, 0.023, 0.021, 0.02, 0.018 };
            for (int i = 0; i < resA.Count; i++)
            {
                Assert.Equal(exp[i], resA[i], 3);
            }
        }

        [Fact]
        public void XnMoreThanXkAndUncorrectDx()
        {
            List<double> res = Program.TaskA(2.0, 4.2, 1.2, 0.7);
            Assert.Equal(res, new List<double>());
        }
    }
}
