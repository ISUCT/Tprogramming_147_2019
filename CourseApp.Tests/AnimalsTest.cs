using System;
using Xunit;

namespace CourseApp.Tests
{
    public class AnimalsTest
    {
        [Fact]
        public void EmptyConstructor()
        {
            Animals[] animals = new Animals[2];
            animals[0] = new Dog();
            animals[1] = new Cat();
            foreach (Animals animal in animals)
            {
                Assert.Equal(1, animal.Age);
                Assert.Equal("male", animal.Sex);
            }
        }

        [Fact]
        public void OneArgumentConstructor()
        {
            Animals[] animals = new Animals[2];
            animals[0] = new Dog("White");
            animals[1] = new Cat("Black");
            Assert.Equal("White", animals[0].Name);
            Assert.Equal("Black", animals[1].Name);
            foreach (Animals animal in animals)
            {
                Assert.Equal(1, animal.Age);
                Assert.Equal("male", animal.Sex);
            }
        }

        [Fact]
        public void ThreeArgumentConstructor()
        {
            Animals[] animals = new Animals[2];
            animals[0] = new Dog("White", 5, "female");
            animals[1] = new Cat("Black", 2, "male");
            Assert.Equal("White", animals[0].Name);
            Assert.Equal("Black", animals[1].Name);
            Assert.Equal(5, animals[0].Age);
            Assert.Equal(2, animals[1].Age);
            Assert.Equal("female", animals[0].Sex);
            Assert.Equal("male", animals[1].Sex);
        }

        [Fact]
        public void ToStringTesting()
        {
            Animals[] animals = new Animals[2];
            animals[0] = new Dog("White", 5, "female");
            animals[1] = new Cat("Black", 2, "male");
            Assert.Equal("Собака по имени White. Её возраст - 5, пол - женский", animals[0].ToString());
            Assert.Equal("Кот по имени Black. Его возраст - 2, пол - мужской", animals[1].ToString());
        }

        [Fact]
        public void ToCompareTest()
        {
            Animals[] animals = new Animals[3];
            animals[0] = new Dog("White", 5, "female");
            animals[1] = new Cat("Black", 2, "male");
            animals[2] = new Dog("Black");
            if (animals[0].CompareTo(animals[1]) == 1 && animals[1].CompareTo(animals[2]) == 0)
            {
                Assert.True(true);
            }
        }
    }
}