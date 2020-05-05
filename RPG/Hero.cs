using System;

namespace RPG
{
    public class Hero
    {
        Random random = new Random();
        public string Name { get; protected set; }
        public int Strength { get; protected set; }
        public int Health { get; set; }
        public string typeClass;
        public string[] skills;
        public string skillName;
        public bool buf = false;
        public string bufName;
        public int sleepTime = 0;
        public int maxHealth;
        public Hero()
        {
            Health = random.Next(100,300);
            maxHealth = Health;
            Name = Names[random.Next(0,9)];
            Strength = random.Next(10,50);
        }
        public static string[] Names = new string[10]{
            "Player1",
            "Player2",
            "Player3",
            "Player4",
            "Player5",
            "Player6",
            "Player7",
            "Player8",
            "Player9",
            "Player10"
        };

        public virtual void Skill(out string skillName, out int damage)
        {
            skillName = "";
            damage = 0;
        }

        public void Atack(out int damage)
        {
            damage = random.Next(1, Strength);
        }

        public int GetDamage(int damage)
        {
            Health -= damage;
            return Health;
        }
    }
}
