using System;

namespace CourseApp
{
    public abstract class Weapon
    {
        public Weapon(string model, double kalibr, bool fire)
        {
            Model = model;
            Kalibr = kalibr;
            Fire = fire;
        }

        public virtual string Model { get; set; }

        public virtual double Kalibr { get; set; }

        public virtual bool Fire { get; set; }

        public virtual bool CanShoot { get; set; }

        public abstract string Shoot(bool canShoot);

        public new virtual string ToString()
        {
            return $"Weapon-{Model}, {Kalibr}, {Fire}";
        }

        public virtual string NumShoot(int shot)
        {
            return $"{Model} made of {shot} shots";
        }
    }
}