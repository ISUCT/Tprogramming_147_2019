using System;
using System.Collections.Generic;
using Xunit;

namespace CourseApp.Tests
{
    public class DemoTest
    {
        [Theory]
        [InlineData(0.2, 45.024015896718936)]
        [InlineData(0.3, 18.87433958817845)]
        public void TestMyFunction(double x, double exp)
        {
            Assert.Equal(Program.MyFunction(x), exp, 3);
        }

        [Fact]

        public void TestTaskA()
        {
            double xn = 0.26;
            double xk = 0.66;
            double dx = 0.08;
            List<double> res = Program.TaskA(xn, xk, dx);
            List<double> expy = new List<double> { 26.84410487237168, 13.21117766406966, 6.447227535266805, 3.220397731030495, 1.7472761588502188, 1.1298385487203866 };
            for (int i = 0; i < 6; i++)
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
        public void TestTaskB()
        {
            List<double> xB = new List<double> { 0.1, 0.35, 0.4, 0.55, 0.6 };
            List<double> taskB = Program.TaskB(xB);
            List<double> expy = new List<double> { 102.99803805648071, 12.078220437571703, 7.709481911813682, 2.16507891445927, 1.5347282613199904 };
            for (int i = 0; i < 5; i++)
            {
                Assert.Equal(expy[i], taskB[i], 3);
            }
        }
    }
}
