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
        public void TestMyFunctionZero()
        {
            var res = Functions.MyFunction(0.0, 0.0, 0.0);
            Assert.Equal(0, res);
        }

        [Fact]
        public void TestEmptyListA()
        {
            double a = 0.1;
            double b = 0.5;
            double xn = 2.15;
            double xk = 1.37;
            double dx = 0.25;
            Assert.Empty(Functions.TaskA(a, b, xn, xk, dx));
        }

        [Fact]
        public void TestTaskA()
        {
            double a = 0.1;
            double b = 0.5;
            double xn = 0.15;
            double xk = 1.37;
            double dx = 0.25;
            List<double> res = Functions.TaskA(a, b, xn, xk, dx);
            List<double> expy = new List<double> { 2.37712776090628 * Math.Pow(10, -05), 0.00022580635007, 0.00090281492133, 0.00270370995817, 0.00689161993993 };
            for (int i = 0; i < 5; i++)
            {
                Assert.Equal(expy[i], res[i], 3);
            }
        }

        [Fact]
        public void TestXnMoreThenXk()
        {
            List<double> res = Functions.TaskA(0.1, 0.5, 1.37, 0.15, 0.25);
            Assert.Equal(res, new List<double>());
        }

        [Fact]
        public void TestDx()
        {
            List<double> res = Functions.TaskA(0.1, 0.5, 1.37, 0.15, 2.0);
            Assert.Equal(res, new List<double>());
        }

        [Fact]
        public void TestEmptyListB()
        {
            List<double> x = new List<double>();
                Assert.Empty(Functions.TaskB(0.1, 0.5, x));
        }

        [Fact]
        public void TestTaskB()
        {
            List<double> x = new List<double> { 0.2, 0.3, 0.44, 0.6, 0.56 };
            List<double> res = Functions.TaskB(0.1, 0.5, x);
            List<double> expy = new List<double> { 4.40297534162119 * Math.Pow(10, -05), 0.000110574248889246, 0.000290504593574433, 0.000704902427233617, 0.000573207189723587 };
            for (int i = 0; i < 5; i++)
            {
                Assert.Equal(expy[i], res[i], 3);
            }
        }
    }
}