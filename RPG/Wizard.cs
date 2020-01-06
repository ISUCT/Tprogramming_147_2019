using System;

namespace RPG
{
    public class Wizard : Hero
    {
        Random random = new Random();

        public Wizard()
        : base()
        {
            skills = new string[]{"Объятия смерти","Жатва душ"};
            typeClass = "Маг";
        }

        public override void Skill(out string skillName, out int damage)
        {
            int probability = random.Next(0, 100);
            if(probability <= 60 && sleepTime == 0)
            {
                skillName = "Объятия смерти";
            }
            else
            {
                skillName = "Жатва душ";
            }

            switch(skillName)
            {
                case "Объятия смерти":
                    sleepTime = 5;
                    damage = 1;
                    break;
                case "Жатва душ":
                    damage = (int)Math.Floor(Strength * 1.5);
                    break;
                default:
                    damage = 1;
                    break;
            }
        }
    }
}
