using System;
using System.Collections.Generic;

namespace RPG
{
    class Logger
    {
        public void Damage(Player damager, Player prey, int damage)
        {
            Console.WriteLine($"{damager.Name}({damager.PClass}) наносит {damage} ед. урона {prey.Name}({prey.PClass})!");
        }
        public void WriteLog(string s)
        {
            Console.WriteLine(s);
        }
        public void WriteLog(Player a, Player b)
        {
            Console.WriteLine($"{a}({a.PClass}) vs {b}({b.PClass})");
        }
        public void WriteLog(Player a, Player b, int damage)
        {
            Console.WriteLine($"{a} наносит {b} {damage} ед. урона");
        }
        public void WhichCon(int con)
        {
            Console.WriteLine($"Начинается {con}-й кон!!!\n");
        }
        public void Winner(Player winner, Player looser)
        {
            Console.WriteLine($"{winner.Name}({winner.PClass}) побеждает {looser.Name}({looser.PClass})!");
        }
    }
}