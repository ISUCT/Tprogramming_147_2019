using System;

namespace CourseApp
{
    public class Pistol : Weapon
    {
        private double kalibr;

        public Pistol()
        : this("No model", 0, true)
        {
        }

        public Pistol(string model, double kalibr, bool hit)
        : base(model, kalibr, hit)
        {
            Model = model;
            Kalibr = kalibr;
            Hit = hit;
        }

        public override string Model { get; set; }

        public override double Kalibr
        {
            get
            {
                return this.kalibr;
            }

            set
            {
                if (value >= 0 && value < 20)
                {
                    this.kalibr = value;
                }
                else
                {
                    throw new Exception("Enter correct kalibr");
                }
            }
        }

        public override bool Hit { get; set; }

        public override string Shoot(bool hit)
        {
            if (hit == true)
            {
                return $"Pistol {Model} and {Kalibr} hit!";
            }
            else
            {
                return $"Pistol {Model} and {Kalibr} not hit!";
            }
        }

        public override string ToString()
        {
            return $"Pistil-{Model}, {Kalibr}, {Hit}";
        }

        public override string NumShoot(int shot)
        {
            return $"{Model} made of {shot} shots";
        }
    }
}