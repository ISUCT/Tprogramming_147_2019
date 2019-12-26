using System;
using Xunit;

namespace CourseApp.Tests
{
    public class ShipTest
    {
        [Fact]
        public void TestEmptyConstructor()
        {
            var item = new Ship();
            Assert.Equal(259, item.KLONG);
            Assert.Equal(463, item.Mass);
            Assert.Equal(523, item.IZM);
        }

        [Fact]
        public void TestView()
        {
            var item = new Ship();
            var view = @"
───│─────────────────────────────────────
───│────────▄▄───▄▄───▄▄───▄▄───────│────
───▌────────▒▒───▒▒───▒▒───▒▒───────▌────
───▌──────▄▀█▀█▀█▀█▀█▀█▀█▀█▀█▀▄─────▌────
───▌────▄▀▄▀▄▀▄▀▄▀▄▀▄▀▄▀▄▀▄▀▄▀▄▀▄───▋────
▀██████████████████████████████████████▄─
──▀███████████████████████████████████▀──
─────▀██████████████████████████████▀────
▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒
▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒
▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒
 ";
            Assert.Equal(view, item.View());
        }

        [Fact]
        public void TestSetLong()
        {
            var item = new Ship();
            item.KLONG = 259;
            Assert.Equal(259, item.KLONG);
        }

        [Fact]
        public void TestIncorrectSetAge()
        {
            var item = new Ship();
            item.Mass = 0;
            Assert.Equal(0, item.Mass);
        }

        [Fact]
        public void TestCorrectIncorrectSetKlong()
        {
            var item = new Ship();
         try
             {
             item.KLONG = 100;
             item.KLONG = -20;
             }
         catch
             {
                Assert.Equal(100, item.KLONG);
             }
        }
    }
}