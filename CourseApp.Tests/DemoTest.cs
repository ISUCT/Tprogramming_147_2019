using System;
using Xunit;

namespace CourseApp.Tests
{
    public class DemoTest
    {
        [Theory]
        [InlineData(0.7, 5, 0.2196741002474553)]
        [InlineData(2.2, 1.7, 0.4091366343551351)] 
        [InlineData(0.1, 4, 0.4617896586816621)]
        public void TestFunction(double b, double x, double exp)
        {
            Assert.Equal(Program.Func(b, x), exp, 3);
        }

        [Fact]
        public void StartTest()
        {
            Xunit.Assert.True(true);
        }

        [Fact]
        public void ZeroFunction()
        {
            var res = Program.Matem(0.0, 0.0);
            Xunit.Assert.Equal(double.PositiveInfinity, res);
        }

        [Fact]
        public void NullMassTest()
        {
            var mass = new double[0];
            var res = Program.TaskB(2, mass);
            Xunit.Assert.Equal(mass, res);
        }

        [Fact]
        public void TestTaskB()
        {
            var x = new double[] { 1.1, 2.4, 3.6, 1.7, 3.9 };
            var res = Program.TaskB(2.5, x);
            var expy = new double[] { 0.750082078454372, 0.639743913195054, 0.504058298008105, 0.699366948598495, 0.381615534970301 };
            for (int i = 0; i < 5; i++)
            {
                Xunit.Assert.Equal(expy[i], res[i], 3);
            }
        }
    }
}
