using System;
using System.Collections.Generic;

namespace RPG
{
    public class Game
    {
        List<Player> Players = new List<Player>();
        Logger logger = new Logger();
        Random random = new Random();
        Player Player1;
        Player Player2;
        int counter = 0;

        public void Start(int numOfPlayers)
        {
            CreatePlayers(numOfPlayers);
            while (Players.Count > 1)
            {
                Fight();
            }

            Console.WriteLine($"\nПобедитель: {Players[0].typeClass} {Players[0].Name}\n");
        }

        public void CreatePlayers(int numOfPlayers)
        {
            while (numOfPlayers > 0)
            {
                switch (random.Next(0, 3))
                {
                    case 0:
                        Players.Add(new Archer());
                        break;
                    case 1:
                        Players.Add(new Knight());
                        break;
                    case 2:
                        Players.Add(new Wizard());
                        break;
                    default:
                        Players.Add(new Wizard());
                        break;
                }

                numOfPlayers--;
            }
        }

        public void Atack(Player Player1, Player Player2)
        {
            int damage;

            if (Player1.buff)
            {
                Player1.Atack(out damage);
                logger.Atack(Player1, Player2, damage);
                Player2.GetDamage(damage + 5);
            }
            else
            {
                Player1.Atack(out damage);
                logger.Atack(Player1, Player2, damage);
                Player2.GetDamage(damage);
            }
        }

        public void UseSkill(Player Player1, Player Player2)
        {
            int damage;
            string skillName;

            if (Player1.buff)
            {
                Player1.Skill(out skillName, out damage);
                logger.Skill(Player1, Player2, skillName, damage);
                Player2.GetDamage(damage + 5);
            }
            else
            {
                Player1.Skill(out skillName, out damage);
                logger.Skill(Player1, Player2, skillName, damage);
                Player2.GetDamage(damage);
            }
        }

        public void Fight()
        {
            int i = random.Next(0, Players.Count - 1);
            Player1 = Players[i];
            Players.RemoveAt(i);

            i = random.Next(0, Players.Count);
            Player2 = Players[i];
            Players.RemoveAt(i);

            int turn = random.Next(0, 1);
            counter++;
            Console.WriteLine("\n/////////////");
            Console.WriteLine($"{counter} бой");
            Console.WriteLine("/////////////\n");

            while (true)
            {
                if (turn == 0)
                {
                    if (Player2.sleepTime == 0)
                    {
                        if (random.Next(0, 10) > 6)
                        {
                            UseSkill(Player1, Player2);
                        }
                        else
                        {
                            Atack(Player1, Player2);
                        }
                    }
                    else
                    {
                        logger.Sleep(Player1);
                        Player2.sleepTime--;
                    }

                    if (Player2.Health <= 0)
                    {
                        Player1.sleepTime = 0;
                        Player1.buff = false;
                        Players.Add(Player1);
                        logger.Winner(Player1);
                        logger.Death(Player2);
                        break;
                    }

                    turn = 1;
                }
                else
                {
                    if (Player1.sleepTime == 0)
                    {
                        if (random.Next(0, 10) > 6)
                        {
                            UseSkill(Player2, Player1);
                        }
                        else
                        {
                            Atack(Player2, Player1);
                        }
                    }
                    else
                    {
                        logger.Sleep(Player2);
                        Player1.sleepTime--;
                    }

                    if (Player1.Health <= 0)
                    {
                        Player2.sleepTime = 0;
                        Player2.buff = false;
                        Players.Add(Player2);
                        logger.Winner(Player2);
                        logger.Death(Player1);
                        break;
                    }

                    turn = 0;
                }
            }
        }
    }
}