using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAssignment
{
    class Gun : IComparable, IAssembled
    {
        public string name { get; private set; }
        public string caliber { get; private set; }
        public double status { get; private set; }
        public int bulletCount { get; private set; }
        public int magazine { get; private set; }

        public Gun()
        {
            name = "";
            caliber = "";
            status = 0;
            magazine = 0;
            bulletCount = 0;
        }

        public Gun(string _name, string _caliber, int _magazine)
        {
            name = _name;
            caliber = _caliber;           
            status = 100;

            if (_magazine > 0)   magazine = _magazine;
            else                 magazine = 1;
            bulletCount = magazine;
        }

        public Gun(string _name, string _caliber, int _magazine, double _status)
        {
            name = _name;
            caliber = _caliber;

            if (status >= 0 && status <= 100)
            {
                status = _status;
            }
            else if (status < 0) status = 0;
            else status = 100;

            if (_magazine > 0)
            {
                magazine = _magazine;
            }
            else magazine = 1;
            bulletCount = magazine;
        }

        public int Fire()
        {           
            if (bulletCount > 0)
            {
                bulletCount -= 1;
            }
            else return -1;

            if (status >= 0.2)
            {
                status -= 0.2;
            }
            else
            {
                status = 0;
                return -2;
            }
            return bulletCount;
        }

        public int Fire(int count)
        {
            count = Math.Abs(count);
            if (bulletCount > 0)
            {
                bulletCount -= count;
            }
            else return -1;

            if (status >= 0.2 * count)
            {
                status -= 0.2 * count;
            }
            else
            {
                status = 0;
                return -2;
            }               
            return bulletCount;
        }

        public int Reload()
        {
            bulletCount = magazine;
            return bulletCount;
        }

        public int Reload(int count)
        {
            if (count <= magazine && count >= 0)
            {
                bulletCount = count;
            }
            else bulletCount = magazine;

            return bulletCount;
        }

        public double Repair()
        {
            status = 100;
            return status;
        }

        public double Repair(int _status)
        {
            if (_status + status > 100)
            {
                status = 100;
            }
            else if(_status < 0) { }
            else status = _status + status;

            return status;
        }

        public override string ToString()
        {
            return "\nМодель: " + name + "\nКалибр: " + caliber
                   + "\nПатронов в магазине: " + magazine + "\nСостояние: " + status + "\n";
        }

        public int CompareTo(object obj)
        {
            return status.CompareTo(obj);
        }

        public string GetInfo()
        {
            return this.ToString();
        }
    }
}
