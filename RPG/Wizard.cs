using System;

namespace RPG
{
    public class Wizard : Player
    {
        public Wizard()
        : base()
        {
            typeClass = "Маг";
            skills = new string[] { "Заворожение", "Огненный шар" };
        }

        public override void Skill(out string skillName, out int damage)
        {
            int probability = random.Next(0, 100);
            if (probability <= 60 && sleepTime == 0)
            {
                skillName = "Заворожение";
            }
            else
            {
                skillName = "Огненный шар";
            }

            switch (skillName)
            {
                case "Заворожение":
                    sleepTime = 2;
                    damage = 0;
                    break;
                case "Огненный шар":
                    damage = (int)Math.Floor(Strength * 2.5);
                    break;
                default:
                    damage = 0;
                    break;
            }
        }
    }
}