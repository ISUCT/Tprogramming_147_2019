using System;
using Xunit;
using System.Collections.Generic;

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

        [Theory]
        [InlineData(2.0, 5.2, 4.2, 0.6)]
        
        public void TestTaskA(double a, double xn, double xk, double dx)
        {
            var res = Program.TaskA(a, xn, xk, dx);
            Assert.Equal(res, new List<double>(5));
        }
        [Fact]
        public void Test1()
        {
            Xunit.Assert.True(true);
        }
        [Fact]
        public void TestZeroFunction()
        {
            var res = Program.Function(0.0, 0.0);
            Xunit.Assert.Equal(double.PositiveInfinity, res);
        }
        [Theory]
        [InlineData(2.0)]     
        public void TestTaskB(double a)
        {
            var mass = new List<double> { 1.16, 1.32, 1.47, 1.65, 1.93 };
            var resultB = Program.TaskB(a, mass);
            var expy = new List<double> { 0.0250047248573638, 0.0246393618709823, 0.0242470198513219, 0.0237322773817727, 0.0228750269630625};
            for (int i = 0; i < 5; i++)
            {
                Assert.Equal(expy[i], resultB[i], 3 );
            }
        }        
    }
}
