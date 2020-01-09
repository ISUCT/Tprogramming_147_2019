using System;

namespace CourseApp
{
    public abstract class Character
    {
        private double level;

        public Character()
        : this("No role", 0, true)
        {
        }

        public Character(string role, double level, bool attack)
        {
            Role = role;
            Level = level;
            Attack = attack;
        }

        public string Role { get; set; }

        public double Level
        {
            get
            {
                return this.level;
            }

            set
            {
                if (value >= 0 && value < 20)
                {
                    this.level = value;
                }
                else
                {
                    throw new Exception("Enter correct level");
                }
            }
        }

        public bool Attack { get; set; }

        public bool CanShoot
        {
            get { return this.Attack; }
        }

        public abstract string Shoot(bool canShoot);

        public new abstract string ToString();

        public virtual string NumShoot(int shot)
        {
            return $"{Role} made of {shot} shots to enemy!";
        }
    }
}