using System;
using Xunit;
using CourseApp;

namespace CourseApp.Tests
{
    public class PigTest
    {
        
        [Fact]
        public void PigTest1()
        {
            Pig svin = new Pig();
            var resAge = svin.Age;
            var resSalo = svin.Salo;
            var resSex = svin.Sex;
            Assert.Equal(20, resAge);
            Assert.Equal(70.0f, resSalo);
            Assert.Equal("Male", resSex);
        }

        [Fact]
        public void PigTest2()
        {
            Pig svin = new Pig("Male");
            var resAge = svin.Age;
            var resSalo = svin.Salo;
            Assert.Equal(20, resAge);
            Assert.Equal(70.0f, resSalo);
        }

        [Fact]
        public void PigTest3()
        {
            Pig svin = new Pig("Female");
            var resAge = svin.Age;
            var resSalo = svin.Salo;
            Assert.Equal(15, resAge);
            Assert.Equal(45.0f, resSalo);
        }

        [Fact]
        public void PigTest4()
        {
            Pig svin = new Pig(57.5f);
            var resAge = svin.Age;
            var resSex = svin.Sex;
            Assert.Equal(20, resAge);
            Assert.Equal("Male", resSex);
        }

        [Fact]
        public void PigTest5()
        {
            Pig svin = new Pig(37.5f);
            var resAge = svin.Age;
            var resSex = svin.Sex;
            Assert.Equal(15, resAge);
            Assert.Equal("Female", resSex);
        }

        [Fact]
        public void PigTest6()
        {
            Pig svin = new Pig(17);
            var resSalo = svin.Salo;
            var resSex = svin.Sex;
            Assert.Equal(65.0f, resSalo);
            Assert.Equal("Male", resSex);
        }

        [Fact]
        public void PigTest7()
        {
            Pig svin = new Pig(8);
            var resSalo = svin.Salo;
            var resSex = svin.Sex;
            Assert.Equal(45.0f, resSalo);
            Assert.Equal("Female", resSex);
        }

        [Fact]
        public void PigTest8()
        {
            Pig svin = new Pig();
            var resRis = svin.Image();
            Assert.Equal(
                @"       _       
      (_)      
 _ __  _  __ _ 
| '_ \| |/ _` |
| |_) | | (_| |
| .__/|_|\__, |
| |       __/ |
|_|      |___/ 
", resRis);
        }

        [Fact]
        public void PigTest9()
        {
            Pig svin = new Pig();
            var resDirt = svin.Dirt();
            Assert.Equal($"свинья возраста {20} пошла поваляться в грязи  ", resDirt);
        }
    }
}