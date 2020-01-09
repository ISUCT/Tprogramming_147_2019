using System;

namespace RPG
{
    public class Hero
    {   
        Random random = new Random();
        public string heroClass;
        public string skillName;
        public bool buf = false;
        public string bufName;
        public int bufDamage;
        public int sleepTime = 0;
        public int maxHealth;
        
        public Hero()
        {
            Health = random.Next(100,200);
            maxHealth = Health;
            Name = Names[random.Next(0,20)];
            Strength = random.Next(10,50);
        }

        public static string[] Names = new string[20]{
            "Kelley",
            "Winifred",
            "Michael",
            "Christina",
            "Lionel",
            "Ami",
            "Jacob",
            "Della",
            "Nicholas",
            "Rose",
            "Edward",
            "Caroline",
            "Clyde",
            "Tiffany",
            "Leo",
            "Marion",
            "Stephen",
            "Maryann",
            "Virgil",
            "Betty"
        };
        public string Name { get; protected set; }
        public int Strength { get; protected set; }
        public int Health { get; set; }
        
        public virtual int Skill()
        {
            return 0;
        }

        public int Atack()
        {
            return random.Next(1, Strength);
        }

        public void GetDamage(int damage)
        {
            Health -= damage;
        }
    }
}
