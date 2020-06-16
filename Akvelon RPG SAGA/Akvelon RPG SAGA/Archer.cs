using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Akvelon_RPG_SAGA
{
    class Archer : Hero
    {
        bool SkillReady = true;

        public Archer(Random random) : base(random)
        {
            typeName = "Лучник";
            nameSkill = "Огненные стрелы";
        }

        public override float UseSkill()
        {
            if(SkillReady)
            {
                return -2;
            }
            else
            {
                return Attack();
            }
        }

        public override float Damage(float _strength)
        {
            if (_strength == -1)
            {
                sleep = true;
                return health;
            }
            else if (_strength == -2)
            {
                fire = true;
                return base.Damage(2);
            }
            else if (fire)
            {
                return base.Damage(_strength + 2);
            }
            else return base.Damage(_strength);
        }

        public override string ToString()
        {
            return base.ToString() + ", класс - " + typeName;
        }
    }
}
