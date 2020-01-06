using System;
using Xunit;

namespace CourseApp.Tests
{
    public class PlatypusTest
    {
        [Fact]
        public void TestCreateTable()
        {
            var item = new Table(12, 13, "white");
            Assert.Equal(12, item.Weigh);
            Assert.Equal(13, item.Height);
            Assert.Equal("white", item.Color);
        }

        [Fact]
        public void TestCreateTableWithoutColor()
        {
            var item = new Table(12, 13);
            Assert.Equal(12, item.Weigh);
            Assert.Equal(13, item.Height);
            Assert.Equal("black", item.Color);
        }

        [Fact]
        public void TestGetToString()
        {
            var ecString = "Table: Weigh = 400, Height = 400, Color = red, Count legs = 4";
            var item = new Table(400, 400, "red");
            Assert.Equal(ecString, item.ToString());
        }

        [Fact]
        public void TestCreateTableWithWrongWeigth()
        {
            try
            {
                var item = new Table(0, 12, "red");
            }
            catch (Exception exc)
            {
                Assert.Equal("Value does not fall within the expected range.", exc.Message);
            }
        }

        [Fact]
        public void TestCreateTableWithWrongHeigth()
        {
            try
            {
                var item = new Table(12, 0, "red");
            }
            catch (Exception exc)
            {
                Assert.Equal("Value does not fall within the expected range.", exc.Message);
            }
        }

        [Fact]
        public void TestCreateTableWithWrongColorNull()
        {
            try
            {
                var item = new Table(12, 12, null);
            }
            catch (Exception exc)
            {
                Assert.Equal("Value does not fall within the expected range.", exc.Message);
            }
        }

        [Fact]
        public void TestCreateTableWithWrongColorEmpty()
        {
            try
            {
                var item = new Table(12, 12, string.Empty);
            }
            catch (Exception exc)
            {
                Assert.Equal("Value does not fall within the expected range.", exc.Message);
            }
        }
    }
}
