using System;
using System.Collections.Generic;

namespace RPG
{
    public static class Logger
    {
        public static void Damage(Player damager, Player prey, int damage)
        {
            Console.WriteLine($"{damager.Name}({damager.PClass}) наносит {damage} ед. урона {prey.Name}({prey.PClass})!");
        }
        public static void WriteLog(string s)
        {
            Console.WriteLine(s);
        }
        public static void WriteLog(Player a, Player b)
        {
            Console.WriteLine($"{a}({a.PClass}) vs {b}({b.PClass})");
        }
        public static void WriteLog(Player a, Player b, int damage)
        {
            Console.WriteLine($"{a} наносит {b} {damage} ед. урона");
        }
        public static void WhichCon(int con)
        {
            Console.WriteLine($"\n --====================-- \n   Начинается {con}-й кон!!!\n --==================--");
        }
        public static void Winner(Player winner, Player looser)
        {
            Console.WriteLine($"{winner.Name}({winner.PClass}) побеждает {looser.Name}({looser.PClass})!");
        }
    }
}