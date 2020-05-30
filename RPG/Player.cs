using System;

namespace RPG
{
    public abstract class Player
    {
        public string typeClass;
        public string[] skills;
        public string skillName;
        public bool buff = false;
        public string buffName;
        public int sleepTime = 0;
        public int maxHealth;
        protected static readonly Random random = new Random();

        public Player()
        {
            Health = random.Next(50, 100);
            maxHealth = Health;
            Name = Names[random.Next(0, 9)];
            Strength = random.Next(10, 30);
        }

        public static string[] Names = { "Akuma", "Geki", "Retsy", "Balrog", "Vaiper", "Juli", "Set", "Fei Long", "Xokyto", "Ingrid" };

        public string Name { get; protected set; }

        public int Strength { get; protected set; }

        public int Health { get; set; }

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
