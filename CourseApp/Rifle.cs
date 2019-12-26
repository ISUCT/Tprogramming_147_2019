using System;

namespace CourseApp
{
    public class Rifle : Weapon
    {
        private double kalibr;

        public Rifle()
        : this("No model", 0, true)
        {
        }

        public Rifle(string model, double kalibr, bool fire)
        : base(model, kalibr, fire)
        {
            Model = model;
            Kalibr = kalibr;
            Fire = fire;
        }

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

        public override bool CanShoot
        {
            get { return this.Fire; }
        }

        public override string ToString()
        {
            return $"Rifle-{Model}, {Kalibr}, {Fire}";
        }

        public override string Shoot(bool canShoot)
        {
            if (canShoot == true)
            {
                return $"Rifle {Model} and {Kalibr} made the shot!";
            }
            else
            {
                return $"Rifle {Model} and {Kalibr} not made the shot!";
            }
        }
    }
}