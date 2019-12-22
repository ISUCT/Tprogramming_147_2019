using System;

namespace CourseApp
{
    public class Hero
    {
        private double level;

        public Hero()
        : this("No role", 0, true)
        {
        }

        public Hero(string role, double level, bool attack)
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

        public string Shoot(bool canShoot)
        {
            if (canShoot == true)
            {
                return $"Hero {Role} and {Level} made the shot!";
            }
            else
            {
                return $"Hero {Role} and {Level} not made the shot!";
            }
        }

        public override string ToString()
        {
            return $"Hero-{Role}, {Level}, {Attack}";
        }

        public string NumShoot(int shot)
        {
            return $"{Role} made of {shot} shots!";
        }
    }
}