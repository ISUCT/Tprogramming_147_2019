using System;
using Xunit;

namespace CourseApp.Tests
{
    public class DemoTest
    {
        [Theory]

        [InlineData(2.0, 5.2, 4.2, 0.6)]
        public void TestTaskA(double a, double xn, double xk, double dx)
        {
            var res = Program.TaskA(a, xn, xk, dx);
            Assert.Equal(res, new double[5]);

        [InlineData(0, 0, 0, double.NaN)]
        [InlineData(1, 1, 2, 2.5)]
        [InlineData(-1, 1, 1, 0)]
        public void TestCalc(double a, double b, double x, double exp)
        {
            var res = Program.MyFunction(a, b, x);
            Assert.Equal(exp, res, 3);
        }

        [Fact]
        public void TestNormalA()
        {
        }

        [Fact]
        public void TestNormalB()
        {
        }

        [Fact]
        public void TestZeroLengthB()
        {
            var res = Program.TaskB(1, 1, new double[0]);
            Assert.Empty(res);

        }
        [Theory]
        [InlineData(2.0, 1.2, 4.2, 0.6)]
        public void Test(double a, double xn, double xk, double dx)
        {
            int k = 0;
            var resultA = Program.TaskA(a, xn, xk, dx);
            var result = new int[resultA.Length];
            foreach (var item in resultA)
            {
                result[k] = (int)Math.Floor(resultA[k]*1000);
                k++;
            }    
            var exp = new int[] {24, 23, 21, 19, 17};
            Assert.Equal(result, exp);
        }
        [Theory]
        [InlineData(2.0)]     
        public void TestTaskB(double a)
        {
            var mass = new double[] { 1.16, 1.32, 1.47, 1.65, 1.93 };
            var resultB = Program.TaskB(a, mass);
            var expy = new double[] { 0.0250047248573638, 0.0246393618709823, 0.0242470198513219, 0.0237322773817727, 0.0228750269630625};
            for (int i = 0; i < 5; i++)
            {
                Assert.Equal(expy[i], resultB[i], 3 );
            }
        }        
    }
}
