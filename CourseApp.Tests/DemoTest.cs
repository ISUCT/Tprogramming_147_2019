using System;
using System.Collections.Generic;
using Xunit;

namespace CourseApp.Tests
{
    public class DemoTest
    {
        [Fact]
        public void TestFunc()
        {
            var res = Program.MyFunction(0, 0);
            Assert.Equal(double.PositiveInfinity, res, 3);
        }

        [Fact]
        public void TestTaskA()
        {
            double a = 2;
            double xn = 1.2;
            double xk = 4.2;
            double dx = 0.6;
            List<double> res = Program.TaskA(a, xn, xk, dx);
            List<double> exp = new List<double> { 0.024919580136386867, 0.02327901792977313, 0.02138591667754329, 0.019542362678459768, 0.01785029731362981 };
            for (int i = 0; i < exp.Count; i++)
            {
                Assert.Equal(exp[i], res[i], 3);
            }
        }

        [Fact]
        public void TestTastAUncorrect()
        {
            List<double> res = Program.TaskA(3, 4.2, 1.2, 0.7);
            Assert.Equal(new List<double>(), res);
        }

        [Fact]
        public void TestTaskB()
        {
            List<double> xB = new List<double> { 1.16, 1.32, 1.47, 1.65, 1.93 };
            List<double> res = Program.TaskB(2, xB);
            List<double> exp = new List<double> { 0.025004724857363752, 0.024639361870982292, 0.024247019851321865, 0.023732277381772752, 0.022875026963062515 };
            for (int i = 0; i < exp.Count; i++)
            {
                Assert.Equal(exp[i], res[i], 3);
            }
        }

        [Fact]
        public void TestZeroLengthB()
        {
            var res = Program.TaskB(0, new List<double>());
            Assert.Empty(res);
        }
    }
}
