using System;

namespace CourseApp
{
    public abstract class SuperClass
    {
        private int izm;

        private int klong;

        private int mass;

        public SuperClass(int klong, int mass, int izm)
        {
            KLONG = klong;
            Mass = mass;
            IZM = izm;
        }

        public int KLONG
        {
            get
            {
                return this.klong;
            }

            set
            {
                if (value < 1 || value > 260)
                {
                    throw new System.Exception($"Long mast be more then 0 and mast be smoler then 260");
                }
                else
                {
                    this.klong = value;
                }
            }
        }

        public int Mass
        {
            get
            {
                return this.mass;
            }

            set
            {
                if (value <= 0 && value >= 464)
                {
                    throw new System.Exception($"Mass mast be more then 0, bat no more then 464");
                }
                else
                {
                    this.mass = value;
                }
            }
        }

        public int IZM
        {
            get
            {
                return this.izm;
            }

            set
            {
                if (value <= 0)
                {
                    throw new System.Exception($"Izm must be more then 0");
                }
                else
                {
                    this.izm = value;
                }
            }
        }

        public abstract string View();

        public virtual string Swim(string kyda)
        {
            return $"The ship Denis swim to {kyda}";
        }

        public virtual string Signal(string tyty)
        {
            return $"The ship Denis make signal {tyty}";
        }
    }
}