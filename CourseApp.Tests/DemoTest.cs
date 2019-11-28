using System;
using Xunit;

namespace CourseApp.Tests
{
    public class DemoTest
    {
        [Fact]
        public void Test1()
        {
            Assert.True(true);
        }

        [Fact]
        public void TestMyFunctionZeros()
        {
            var res = Program.Formula(0.0, 0.0);
            Assert.Equal(double.NaN, res);
        }

        [Fact]
        public void TestTaskB()
        {
            var x = new double[] { 1.84, 4.05, 3.67, 2.18, 1.17 };
            var res = Program.TaskB(1.6, x);
            var expy = new double[] { 3.691061372588238, 1392.8345934281351, 350.7785466064311, 6.25933353327923, 2.622414465082322 };
            for (int i = 0; i < 5; i++)
            {
                Assert.Equal(expy[i], res[i], 3);
            }
        }

        [Fact]
        public void TestTaskA()
        {
            double a = 1.6;
            double xn = 1.2;
            double xk = 3.7;
            double dx = 0.5;
            var res = Program.TaskA(a, xn, xk, dx);
            var expy = new double[] { 2.58628588710697, 3.15454831838707, 6.49450906742811, 19.428489457705, 76.9595290357977 };
            for (int i = 0; i < 5; i++)
            {
                Assert.Equal(expy[i], res[i], 3);
            }
        }
    }
}
