using System;

namespace RPG
{
    public class Archer : Hero
    {
        Random random = new Random();

        public Archer()
        : base()
        {
            typeClass = "Лучник";
            skills = new string[]{"Самонаводящаяся стрела", "Скоростная стрельба", "Стрела стихий"};
        }

        public override void Skill(out string skillName, out int damage)
        {
            int probability = random.Next(0, 100);
            if(!buf)
            {
                if(probability <= 15)
                {
                    skillName = "Стрела стихий";
                }
                else if(probability <= 70)
                {
                    skillName = "Самонаводящаяся стрела";
                }
                else
                {
                    skillName = "Скоростная стрельба";
                }
            }
            else
            {
                if(probability <= 50)
                {
                    skillName = "Стрела стихий";
                }
                else
                {
                    skillName = "Скоростная стрельба";
                }
            }

            switch(skillName)
            {
                case "Стрела стихий":
                    damage = (int)(Strength * 1.8);
                    break;
                case "Скоростная стрельба":
                    damage = (int)(Strength * 2.5);
                    break;
                case "Самонаводящаяся стрела":
                    bufName = "Самонаводящаяся стрела";
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
