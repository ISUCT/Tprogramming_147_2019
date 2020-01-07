using System;
using System.Collections.Generic;

namespace RPG
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            Console.Write("Введите число игроков: ");

            int numOfPlayers = Int32.Parse(Console.ReadLine());

            if (numOfPlayers % 2 != 0)
            {
                numOfPlayers += 1;
            }

            game.Start(numOfPlayers);

            Console.ReadKey();
        }
    }
}