using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Akvelon_RPG_SAGA
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите кол-во персонажей (четное): ");
            int count  = int.Parse(Console.ReadLine());

            if(count % 2 != 0)
            {
                count -= 1;
            }

            Logger log = new Logger();
            Game game = new Game();


            game.Create(count);
            log.WriteAllHeroes(game);
            game.Start();

            Console.ReadKey();
        }
    }
}
