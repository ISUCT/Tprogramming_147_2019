﻿using System;

namespace RPG
{
    class Logger
    {
        public void Atack(Hero hero1, Hero hero2, int damage)
        {
            if(hero1.typeClass == "Рыцарь")
            {
                Console.Write($"{hero1.typeClass} {hero1.Name} ({hero1.Health} / {hero1.maxHealth}) ударил мечом {hero2.typeClass} {hero2.Name} ({hero2.Health} / {hero2.maxHealth}) и нанёс {damage} урона.");
            } 
            else if(hero1.typeClass == "Лучник")
            {
                Console.Write($"{hero1.typeClass} {hero1.Name} ({hero1.Health} / {hero1.maxHealth}) выстрелил в {hero2.typeClass} {hero2.Name} ({hero2.Health} / {hero2.maxHealth}) и нанёс {damage} урона.");
            } 
            else
            {
                Console.Write($"{hero1.typeClass} {hero1.Name} ({hero1.Health} / {hero1.maxHealth}) ударил посохом {hero2.typeClass} {hero2.Name} ({hero2.Health} / {hero2.maxHealth}) и нанёс {damage} урона.");
            }
            
            if(hero1.buf)
            {
                Console.WriteLine($" Дополнительный урон 5 единиц из-за усиления \"{hero1.bufName}\".");
            }
            else
            {
                Console.WriteLine();
            }
        }

        public void Skill(Hero hero1, Hero hero2, string skillName, int damage)
        {
            if(hero1.sleepTime > 0 && damage == 0)
            {
                Console.WriteLine($"{hero1.typeClass} {hero1.Name} ({hero1.Health} / {hero1.maxHealth}) использует умение \"{skillName}\" и оглушает {hero2.typeClass} {hero2.Name} ({hero2.Health} / {hero2.maxHealth}) на {hero1.sleepTime} хода.");
            }
            else if(hero1.sleepTime > 1)
            {
                Console.WriteLine($"{hero1.typeClass} {hero1.Name} ({hero1.Health} / {hero1.maxHealth}) использовал(-a) умение \"{skillName}\" и нанес(-ла) {hero2.typeClass} {hero2.Name} {damage} урона. {hero2.typeClass} {hero2.Name} ({hero2.Health} / {hero2.maxHealth}) оглушен(-а) на {hero1.sleepTime} ход(-а).");
            }
            else if(hero1.buf && damage == 0)
            {
                Console.WriteLine($"{hero1.typeClass} {hero1.Name} ({hero1.Health} / {hero1.maxHealth}) активировал усиление \"{skillName}\"");
            }
            else
            {
                Console.Write($"{hero1.typeClass} {hero1.Name} ({hero1.Health} / {hero1.maxHealth}) использовал(-a) умение \"{skillName}\" и нанес(-ла) {hero2.typeClass} {hero2.Name} ({hero2.Health} / {hero2.maxHealth}) {damage} урона.");
                
                if(hero1.buf)
                {
                    Console.WriteLine($" Дополнительный урон 5 единиц из-за усиления \"{hero1.bufName}\".");
                }
                else
                {
                    Console.WriteLine();
                }
            }
        }

        public void Sleep(Hero hero)
        {
            Console.WriteLine($"{hero.typeClass} {hero.Name} ({hero.Health} / {hero.maxHealth}) оглушен(-а) и пропускает ход.");
        }

        public void Winner(Hero hero)
        {
            Console.WriteLine($"{hero.typeClass} {hero.Name} ({hero.Health} / {hero.maxHealth}) победил(-а)!");
        }

        public void Death(Hero hero)
        {
            Console.WriteLine($"{hero.typeClass} {hero.Name} погибает");
        }
    }
}
