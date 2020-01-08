using System;

namespace RPG
{
    public class Knight : Player
    {
        public Knight()
        : base()
        {
            typeClass = "Рыцарь";
            skills = new string[] { "Удар возмездия", "Буря клинков", "Удар смерти" };
        }

        public override void Skill(out string skillName, out int damage)
        {
            int probability = random.Next(0, 100);
            if (probability <= 20)
            {
                skillName = "Удар возмездия";
            }
            else if (probability <= 90)
            {
                skillName = "Буря клинков";
            }
            else
            {
                skillName = "Удар смерти";
            }

            switch (skillName)
            {
                case "Удар возмездия":
                    damage = (int)Math.Floor(Strength * 1.5);
                    break;
                case "Буря клинков":
                    damage = (int)Math.Floor(Strength * 1.3);
                    break;
                case "Удар смерти":
                    sleepTime = 3;
                    damage = (int)Math.Floor(Strength * 2.5);
                    break;
                default:
                    damage = 0;
                    break;
            }
        }
    }
}