using System;
using System.Collections.Generic;
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
        public void TestEmptyListA()
        {
            double a = 0.1;
            double b = 0.5;
            double xn = 1.37;
            double xk = 2.57;
            double dx = 0.3;
            Assert.Empty(Program.TaskA(a, b, xn, xk, dx));
        }

        [Fact]
        public void TestTaskA()
        {
            double a = 0.8;
            double b = 0.4;
            double xn = 1.23;
            double xk = 7.23;
            double dx = 1.2;
            List<double> res = Program.TaskA(a, b, xn, xk, dx);
            List<double> expy = new List<double> { 2.237126168657003, 2.215581361121909, 2.5269082194827885, 2.785377126824208, 3.0079000350329963 };
            for (int i = 0; i < 5; i++)
            {
                Assert.Equal(expy[i], res[i], 3);
            }
        }

        [Fact]
        public void TestXnMoreThenXk()
        {
            List<double> res = Program.TaskA(0.8, 0.4, 1.23, 7.23, 1.2);
            Assert.Equal(res, new List<double>());
        }

        [Fact]
        public void TestDx()
        {
            List<double> res = Program.TaskA(0.8, 0.4, 1.23, 7.23, 1.2);
            Assert.Equal(res, new List<double>());
        }

        [Fact]
        public void TestEmptyListB()
        {
            List<double> x = new List<double>();
                Assert.Empty(Program.TaskB(0.8, 0.4, x));
        }

        [Fact]
        public void TestTaskB()
        {
            List<double> x = new List<double> { 1.88, 2.26, 3.84, 4.55, -6.21 };
            List<double> res = Program.TaskB(0.8, 0.4, x);
            List<double> expy = new List<double> { 2.0558467733507353, 2.1665433513017915, 2.5754036757838303, 2.7287991234367484, double.NaN };
            for (int i = 0; i < 5; i++)
            {
                Assert.Equal(expy[i], res[i], 3);
            }
        }
    }
}
