using System;

namespace RPG
{
    public class Archer : Player
    {
        public Archer()
        : base()
        {
            typeClass = "Лучник";
            skills = new string[] { "Огненные стрелы", "Шквал стрел", "Стрела правосудия" };
        }

        public override void Skill(out string skillName, out int damage)
        {
            int probability = random.Next(0, 100);
            if (!buff)
            {
                if (probability <= 20)
                {
                    skillName = "Стрела правосудия";
                }
                else if (probability <= 90)
                {
                    skillName = "Огненные стрелы";
                }
                else
                {
                    skillName = "Шквал стрел";
                }
            }
            else
            {
                if (probability <= 70)
                {
                    skillName = "Стрела правосудия";
                }
                else
                {
                    skillName = "Шквал стрел";
                }
            }

            switch (skillName)
            {
                case "Стрела правосудия":
                    damage = (int)(Strength * 1.5);
                    break;
                case "Шквал стрел":
                    damage = (int)(Strength * 2.5);
                    break;
                case "Огненные стрелы":
                    buffName = "Огненные стрелы";
                    buff = true;
                    damage = 0;
                    break;
                default:
                    damage = 0;
                    break;
            }
        }
    }
}