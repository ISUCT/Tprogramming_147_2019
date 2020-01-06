using System;
using System.Collections.Generic;
using Xunit;

namespace CourseApp.Tests
{
    public class DemoTest
    {
        [Theory]
        [InlineData(2, 4, 0.01682)]
        [InlineData(10, -5, 0.0195424)]
        public void TestMyFunction(double a, double x, double exp)
        {
            Assert.Equal(Program.Function(a, x), exp, 3);
        }

        [Fact]

        public void TestTaskA()
        {
            double a = 2.0;
            double xn = 1.2;
            double xk = 4.2;
            double dx = 0.6;
            List<double> res = Program.TaskA(a, xn, xk, dx);
            List<double> expy = new List<double> { 0.024919580136386867, 0.02327901792977313, 0.02138591667754329, 0.019542362678459768, 0.01785029731362981 };
            for (int i = 0; i < 5; i++)
            {
                Assert.Equal(expy[i], res[i], 3);
            }
        }

        [Fact]
        public void Test1()
        {
            Assert.True(true);
        }

        [Fact]
        public void TestZeroFunction()
        {
            var res = Program.Function(0.0, 0.0);
            Assert.Equal(double.PositiveInfinity, res);
        }

        [Fact]
        public void TestTaskB()
        {
            List<double> x = new List<double> { 1.16, 1.32, 1.47, 1.65, 1.93 };
            List<double> res = Program.TaskB(2.0, x);
            List<double> expy = new List<double> { 0.025004724857363752, 0.024639361870982292, 0.024247019851321865, 0.023732277381772752, 0.022875026963062515 };
            for (int i = 0; i < 5; i++)
            {
                Assert.Equal(expy[i], res[i], 3);
            }
        }
    }
}
