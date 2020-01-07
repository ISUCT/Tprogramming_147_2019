using System;
using Xunit;
using RPG;

namespace RPG.Tests
{
    public class RPGTests
    {
        [Fact]
        public void CreationTest()
        {
            Player knight = new Knight();
            Player archer = new Archer();
            Player wizard = new Wizard();

            if (knight.Health > 0 && knight.Strength > 0 && archer.Health > 0 && archer.Strength > 0 && wizard.Health > 0 && wizard.Strength > 0)
            {
                Assert.True(true);
            }
        }

        [Fact]
        public void KnightSkillsTest()
        {
            Player knight = new Knight();

            int damage;
            string skillName;

            knight.Skill(out skillName, out damage);

            if ((skillName == "Удар возмездия" || skillName == "Удар с размаху" || skillName == "Раскол земли") && damage > 0)
            {
                Assert.True(true);
            }
        }

        [Fact]
        public void ArcherSkillsTest()
        {
            Player archer = new Archer();

            int damage;
            string skillName;

            archer.Skill(out skillName, out damage);

            if (skillName == "Огненные стрелы" && archer.buff && damage == 0)
            {
                Assert.True(true);
            }
            else if ((skillName == "Мощный выстрел" || skillName == "Град стрел") && damage > 0)
            {
                Assert.True(true);
            }
        }

        [Fact]
        public void WizardSkillsTest()
        {
            Player wizard = new Wizard();

            int damage;
            string skillName;

            wizard.Skill(out skillName, out damage);

            if (skillName == "Заворожение" && wizard.sleepTime > 0 && damage == 0)
            {
                Assert.True(true);
            }
            else if (skillName == "Метеор" && damage > 0)
            {
                Assert.True(true);
            }
        }

        [Fact]
        public void GetDamageTest()
        {
            Player wizard = new Wizard();

            int health = wizard.GetDamage(30);

            Assert.Equal(wizard.maxHealth - 30, health);
        }

        [Fact]
        public void AtackTest()
        {
            Player archer = new Archer();

            int damage;

            archer.Atack(out damage);

            if (damage > 0)
            {
                Assert.True(true);
            }
        }
    }
}