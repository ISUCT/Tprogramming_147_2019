using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Gun gun = new Gun("Пистоль", "31B3", 12, 100);

            Console.WriteLine(gun.ToString());
            Console.WriteLine("Выстрел 1 раз. Остальсь пуль: " + gun.Fire());        
            Console.WriteLine("Полная перезарядка. Кол-во пуль: " + gun.Reload());
            Console.WriteLine("Выстрел 8 раза. Остальсь пуль: " + gun.Fire(8));
            Console.WriteLine("Замена магазина на 6 патронов. Кол-во пуль: " + gun.Reload(6));
            Console.WriteLine(gun.ToString());
            Console.WriteLine("Починка. Состояние: " + gun.Repair());

            Console.ReadKey();
        }
    }
}
