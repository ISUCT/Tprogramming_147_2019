using System;
using System.Collections.Generic;
using Xunit;

namespace CourseApp.Tests
{
    public class FunctionTest
    {
        [Theory]
        [InlineData(0, double.NegativeInfinity)]
        [InlineData(2, 0.2)]
        [InlineData(1, 0)]
        public void TestCalc(double x, double exp)
        {
            var res = Function.MyFunction(x);
            Assert.Equal(exp, res, 1);
        }

        [Fact]
        public void TestNormalA()
        {
            List<double> action = Function.TaskA(0.11, 0.36, 0.05);
            List<double> s = new List<double>() { -0.942599174573112, -0.768989662415832, -0.640224062047432, -0.537938691770828, -0.453755045309719 };
            for (var i = 0; i < 5; i++)
            {
                Assert.Equal(action[i], s[i], 3);
            }
        }

        [Fact]
        public void TestNormalB()
        {
            List<double> x = new List<double> { 0.2, 0.3, 0.38, 0.43, 0.57 };
            var actial = Function.TaskB(x);
            List<double> exp = new List<double> { -0.663479953941618, -0.469395196867133, -0.357994574230452, -0.301819984896032, -0.184040925422074 };
            for (var i = 0; i < 5; i++)
            {
                Assert.Equal(exp[i], actial[i], 3);
            }
        }

        [Fact]
        public void TestZeroLengthB()
        {
            var res = Function.TaskB(new List<double>());
            Assert.Empty(res);
        }
    }
}
