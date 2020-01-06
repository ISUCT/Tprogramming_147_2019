using System;

namespace CourseApp
{
    public class Enemy : Character
    {
        public Enemy()
        : this("No role", 0, true)
        {
        }

        public Enemy(string role, double level, bool attack)
        : base(role, level, attack)
        {
        }

        public override string Shoot(bool canShoot)
        {
            if (canShoot == true)
            {
                return $"Enemy {Role} and {Level} made the shot!";
            }
            else
            {
                return $"Enemy {Role} and {Level} not made the shot!";
            }
        }

        public override string ToString()
        {
            return $"Enemy-{Role}, {Level}, {Attack}";
        }

        public override string NumShoot(int shot)
        {
            return $"{Role} made of {shot} to himself!";
        }
    }
}