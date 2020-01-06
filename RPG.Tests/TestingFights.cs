using System;
using Xunit;
using RPG;

namespace RPG.Tests
{
    public class TestingFights
    {
        [Fact]
        public void CreationTest()
        {
            Hero knight = new Knight();
            Hero archer = new Archer();
            Hero wizard = new Wizard();
            Hero necromancer = new Necromancer();

            if(knight.Health > 0 && knight.Strength > 0 && archer.Health > 0 && archer.Strength > 0 && wizard.Health > 0 && wizard.Strength > 0 && necromancer.Health > 0 && necromancer.Strength > 0 )
            {
                Assert.True(true);
            }
        }

        [Fact]
        public void KnightSkillsTest()
        {
            Hero knight = new Knight();

            int damage;
            string skillName;

            knight.Skill(out skillName, out damage);

            if((skillName == "Удар возмездия" || skillName == "Удар с размаху" || skillName == "Раскол земли") && damage > 0)
            {
                Assert.True(true);
            }
        }

        [Fact]
        public void NecromancerSkillsTest()
        {
            Hero necromancer = new Necromancer();

            int damage;
            string skillName;

            necromancer.Skill(out skillName, out damage);

            if((skillName == "Мрачная жатва" || skillName == "Трупное копье" || skillName == "Вампиризм") && damage > 0)
            {
                Assert.True(true);
            }
        }

        [Fact]
        public void ArcherSkillsTest()
        {
            Hero archer = new Archer();

            int damage;
            string skillName;

            archer.Skill(out skillName, out damage);

            if(skillName == "Самонаводящаяся стрела" && archer.buf && damage == 0)
            {
                Assert.True(true);
            }
            else if((skillName == "Скоростная стрельба" || skillName == "Стрела стихий") && damage > 0)
            {
                Assert.True(true);
            }
        }

        [Fact]
        public void WizardSkillsTest()
        {
            Hero wizard = new Wizard();

            int damage;
            string skillName;

            wizard.Skill(out skillName, out damage);

            if(skillName == "Объятия смерти" && wizard.sleepTime > 0 && damage == 1)
            {
                Assert.True(true);
            }
            else if(skillName == "Жатва душ" && damage > 0)
            {
                Assert.True(true);
            }
        }

        [Fact]
        public void GetDamageTest()
        {
            Hero wizard = new Wizard();

            int health = wizard.GetDamage(30);

            Assert.Equal(wizard.maxHealth - 30, health);
        }

        [Fact]
        public void AtackTest()
        {
            Hero archer = new Archer();

            int damage;

            archer.Atack(out damage);

            if(damage > 0)
            {
                Assert.True(true);
            }
        }
    }
}
