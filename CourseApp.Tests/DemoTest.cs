using System;
using Xunit;

namespace CourseApp.Tests
{
    public class DemoTest
    {
        [Fact]
        public void TestTaskBNullMass()
        {
            double[] e = new double[0];
            var res = Program.TaskB(2.0, e);
            Assert.Equal(res, new double[0]);
        }

        [Fact]
        public void TaskBWork()
        {
            var arr = new double[] { 1.02, 1.21, 1.5, 2.3, 2.71 };
            var resB = Program.TaskB(2.0, arr);
            var exp = new double[] { 0.02526278072091896, 0.02489759880547166, 0.024164084643521107, 0.021702665452373534, 0.020418098612637083 };
            for (int i = 0; i < 5; i++)
            {
                Assert.Equal(resB[i], exp[i]);
            }
        }

        [Theory]
        [InlineData(2.0, 1.2, 4.2, 0.6)]
        public void TaskAWork(double a, double xn, double xk, double dx)
        {
            var resA = Program.TaskA(a, xn, xk, dx);
            var result = new double[resA.Length];
            int j = 0;

            foreach (var item in resA)
            {
                result[j] = Math.Round(resA[j], 3);
                j++;
            }

            var exp = new double[] { 0.025, 0.023, 0.021, 0.02, 0.018 };
            Assert.Equal(result, exp);
        }
    }
}
