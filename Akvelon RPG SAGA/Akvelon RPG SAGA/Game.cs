using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Akvelon_RPG_SAGA
{
    public struct Fight
    {
        public Hero hero1;
        public Hero hero2;
    }


    class Game
    {
        public List<Hero> heroes = new List<Hero>();
        public List<Fight> figth = new List<Fight>();
        int countPlayers; 
        Random rand = new Random();
        Logger log = new Logger();
        int round = 0;

        public void Create(int count)
        {                    
            countPlayers = count;
            for (int i = 0; i < countPlayers; i++)
            {
                int k = rand.Next(0,3);
                switch (k)
                {
                    case 0:
                        heroes.Add(new Swordsman(rand));
                        break;
                    case 1:
                        heroes.Add(new Magician(rand));
                        break;                     
                    case 2:
                        heroes.Add(new Archer(rand));
                        break;
                    default:
                        heroes.Add(new Swordsman(rand));
                        break;
                }               
            }
        }

        public void Start()
        {
            while(true)
            {
                CreateFights();
                for (int i = 0; i < figth.Count; i++)
                {
                    StartBattle(i);
                }
                figth.Clear();

                if(heroes.Count == 1)
                {
                    break;
                }
            }

            log.Winer(heroes[0]);
        }

        void CreateFights()
        {
            while (heroes.Count > 1)
            {
                int k = rand.Next(0, heroes.Count - 1);
                Fight buf = new Fight();
                buf.hero1 = heroes[k];
                heroes.RemoveAt(k);

                k = rand.Next(0, heroes.Count);
                buf.hero2 = heroes[k];
                heroes.RemoveAt(k);

                figth.Add(buf);
            }
        }

        void StartBattle(int index)
        {
            round++;
            log.Round(round);

            Hero hero1 = figth[index].hero1;
            Hero hero2 = figth[index].hero2;

            int Move; 
            int k = rand.Next(0, 10);
            if (k < 5) Move = 1;
            else Move = 2;

            while (true)
            {
                if (Move == 1)
                {
                    int luck = rand.Next(0, 50);
                    if (luck <= 40)
                    {
                        hero2.Damage(hero1.Attack());
                        log.Attack(hero1, hero2, hero1.Attack());
                    }
                    else
                    {
                        hero2.Damage(hero1.UseSkill());
                        log.Skill(hero1, hero2, hero1.nameSkill);
                    }
                    Move = 2;

                    if(hero2.health <= 0)
                    {
                        hero1.StopBaf();
                        heroes.Add(hero1);
                        log.Dead(hero2);
                        break;
                    }
                }
                else
                {
                    int luck = rand.Next(0, 50);
                    if (luck <= 40)
                    {
                        hero1.Damage(hero2.Attack());
                        log.Attack(hero2, hero1, hero2.Attack());
                    }
                    else
                    {
                        hero1.Damage(hero2.UseSkill());
                        log.Skill(hero2, hero1, hero2.nameSkill);
                    }
                    Move = 1;

                    if (hero1.health <= 0)
                    {
                        hero2.StopBaf();
                        heroes.Add(hero2);
                        log.Dead(hero1);
                        break;
                    }
                }

            }



        }


    }
}
