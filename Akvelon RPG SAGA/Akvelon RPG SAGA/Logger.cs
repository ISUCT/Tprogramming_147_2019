using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Akvelon_RPG_SAGA
{
    class Logger
    {
        public void WriteAllHeroes(Game game)
        {
            for (int i = 0; i < game.heroes.Count; i++)
            {
                Console.WriteLine(game.heroes[i].ToString());
            }
            Console.WriteLine();
        }

        public void Attack(Hero hero1, Hero hero2, float damage)
        {
            Console.WriteLine($"({hero1.typeName}) {hero1.name} наносит игроку ({hero2.typeName}) {hero2.name} урона = {damage}");
        }


        public void Skill(Hero hero1, Hero hero2, string _nameSkill)
        {
            Console.WriteLine($"({hero1.typeName}) {hero1.name} использует скилл {_nameSkill} на ({hero2.typeName}) {hero2.name}");
        }


        public void Dead(Hero hero)
        {
            Console.WriteLine($"Игрок ({hero.typeName}) {hero.name} был убит!\n");
        }

        public void Round(int num)
        {
            Console.WriteLine($"Раунд {num} начался:");
        }

        public void Winer(Hero hero)
        {
            Console.WriteLine("Победил игрок: " +  hero.ToString());
        }

    }
}
