using System;

namespace CourseApp
{
    public class Pistol
    {
        private double kalibr;

        public Pistol()
        : this("No model", 0, true)
        {
        }

        public Pistol(string model, double kalibr, bool fire)
        {
            Model = model;
            Kalibr = kalibr;
            Fire = fire;
        }

        public string Model { get; set; }

        public double Kalibr
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
                    Console.WriteLine("Enter correct kalibr");
                }
            }
        }

        public bool Fire { get; set; }

        public bool CanShoot
        {
            get { return this.Fire; }
        }

        public string Shoot(bool canShoot)
        {
            if (canShoot == true)
            {
                return $"Pistol {Model} and {Kalibr} made the shot!";
            }
            else
            {
                return $"Pistol {Model} and {Kalibr} not made the shot!";
            }
        }

        public override string ToString()
        {
            return $"Pistol-{Model}, {Kalibr}, {Fire}";
        }

        public string NumShoot(int shot)
        {
            return $"{Model} made of {shot} shots";
        }
    }
}