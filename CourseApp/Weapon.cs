using System;

namespace CourseApp
{
    public abstract class Weapon
    {
        public Weapon(string model, double kalibr, bool hit)
        {
            Model = model;
            Kalibr = kalibr;
            Hit = hit;
        }

        public virtual string Model { get; set; }

        public virtual double Kalibr { get; set; }

        public virtual bool Hit { get; set; }

        public abstract string Shoot(bool canShoot);

        public new virtual string ToString()
        {
            return $"Weapon-{Model}, {Kalibr}, {Hit}";
        }

        public virtual string NumShoot(int shot)
        {
            return $"{Model} made of {shot} shots";
        }
    }
}