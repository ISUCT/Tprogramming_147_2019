using System;

namespace CourseApp
{
    public class Hero : Character
    {
        public Hero()
        : this("No role", 0, true)
        {
        }

        public Hero(string role, double level, bool attack)
        : base(role, level, attack)
        {
        }

        public override string Shoot(bool canShoot)
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

        public override string NumShoot(int shot)
        {
            return $"{Role} made of {shot} shots!";
        }
    }
}