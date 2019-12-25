using System;
using Xunit;

namespace CourseApp.Tests
{
    public class MediaTest
    {
        [Fact]
        public void IfNoConstrForMusic()
        {
            var item = new Music();
            Assert.Equal(10, item.Year);
            Assert.Equal("No title", item.Name);
            Assert.Equal("No country", item.Country);
        }

        [Fact]
        public void VirtMethod()
        {
            var item = new Movie();
            Assert.Equal("Toki Wa Tomare!", item.Za_Warudo());
        }
    }
}