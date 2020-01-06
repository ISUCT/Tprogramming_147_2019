using System;

namespace RPG
{
    public class Necromancer : Hero
    {
        Random random = new Random();

        public Necromancer()
        : base()
        {
            typeClass = "Некромант";
            skills = new string[]{"Мрачная жатва", "Трупное копье", "Вампиризм"};
        }

        public override void Skill(out string skillName, out int damage)
        {
            int probability = random.Next(0, 100);
            if(!buf)
            {
                if(probability <= 15)
                {
                    skillName = "Вампиризм";
                }
                else if(probability <= 70)
                {
                    skillName = "Мрачная жатва";
                }
                else
                {
                    skillName = "Трупное копье";
                }
            }
            else
            {
                if(probability <= 50)
                {
                    skillName = "Вампиризм";
                }
                else
                {
                    skillName = "Трупное копье";
                }
            }

            switch(skillName)
            {
                case "Вампиризм":
                    damage = (int)(Strength * 1.8);
                    break;
                case "Мрачная жатва":
                    damage = (int)(Strength * 2.5);
                    break;
                case "Трупное копье":
                    bufName = "Трупное копье";
                    buf = true;
                    damage = 0;
                    break;
                default:
                    damage = 0;
                    break;
            }
        }
    }
}
