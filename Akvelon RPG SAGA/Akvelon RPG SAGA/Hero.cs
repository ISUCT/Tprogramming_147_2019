using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Akvelon_RPG_SAGA
{
    public class Hero
    {
        public static string[] Names = {
            "Edward",
            "Donald",
            "Dwight",
            "Robert",
            "Paul",
            "Chloe",
            "Deborah",
            "Anissa",
            "Elizabeth",
            "Frederica"
        };


        public float health { get; protected set; }
        protected float strength;
        public string name { get; protected set; }
        public string typeName { get; protected set; }
        protected bool sleep = false;
        public bool fire { get; protected set; } = false;
        public string nameSkill { get; protected set; }


        public Hero(Random random)
        {
            health = random.Next(50,200);
            strength = random.Next(10, 50);
            name = Names[random.Next(0,10)];
        }

        public virtual float UseSkill()
        {
            return 0;
        }

        public virtual float Attack()
        {
            if(sleep)
            {
                sleep = false;
                return 0;
            }
            else return strength;
        }

        public virtual float Damage(float _strength)
        {
            health -= _strength;
            return health;
        }

        public void StopBaf()
        {
            sleep = false;
            fire = false;
        }



        public override string ToString()
        {
            return name + ", здоровье - " + health.ToString() + ", cила - " + strength.ToString();  
        }

    }
}
