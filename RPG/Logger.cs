using System;

namespace RPG
{
    class Logger
    {
        public void Atack(Player Player1, Player Player2, int damage)
        {
            if (Player1.typeClass == "Рыцарь")
            {
                Console.Write($"{Player1.typeClass} {Player1.Name} ({Player1.Health} из {Player1.maxHealth} hp) ударил мечом {Player2.typeClass} {Player2.Name} ({Player2.Health} из {Player2.maxHealth} hp) и нанёс {damage} урона.");
            }
            else if (Player1.typeClass == "Лучник")
            {
                Console.Write($"{Player1.typeClass} {Player1.Name} ({Player1.Health} из {Player1.maxHealth} hp) выстрелил в {Player2.typeClass} {Player2.Name} ({Player2.Health} из {Player2.maxHealth} hp) и нанёс {damage} урона.");
            }
            else
            {
                Console.Write($"{Player1.typeClass} {Player1.Name} ({Player1.Health} из {Player1.maxHealth} hp) ударил посохом {Player2.typeClass} {Player2.Name} ({Player2.Health} из {Player2.maxHealth} hp) и нанёс {damage} урона.");
            }

            if (Player1.buff)
            {
                Console.WriteLine($" Дополнительный урон 5 единиц из-за усиления \"{Player1.buffName}\".");
            }
            else
            {
                Console.WriteLine();
            }
        }

        public void Skill(Player Player1, Player Player2, string skillName, int damage)
        {
            if (Player1.sleepTime > 0 && damage == 0)
            {
                Console.WriteLine($"{Player1.typeClass} {Player1.Name} ({Player1.Health} из {Player1.maxHealth} hp) использует умение \"{skillName}\" и оглушает {Player2.typeClass} {Player2.Name} ({Player2.Health} из {Player2.maxHealth} hp) на {Player1.sleepTime} хода.");
            }
            else if (Player1.sleepTime > 1)
            {
                Console.WriteLine($"{Player1.typeClass} {Player1.Name} ({Player1.Health} из {Player1.maxHealth} hp) использовал(-a) умение \"{skillName}\" и нанес(-ла) {Player2.typeClass} {Player2.Name} {damage} урона. {Player2.typeClass} {Player2.Name} ({Player2.Health} из {Player2.maxHealth} hp) оглушен(-а) на {Player1.sleepTime} ход(-а).");
            }
            else if (Player1.buff && damage == 0)
            {
                Console.WriteLine($"{Player1.typeClass} {Player1.Name} ({Player1.Health} из {Player1.maxHealth} hp) активировал усиление \"{skillName}\"");
            }
            else
            {
                Console.Write($"{Player1.typeClass} {Player1.Name} ({Player1.Health} из {Player1.maxHealth} hp) использовал(-a) умение \"{skillName}\" и нанес(-ла) {Player2.typeClass} {Player2.Name} ({Player2.Health} из {Player2.maxHealth} hp) {damage} урона.");

                if (Player1.buff)
                {
                    Console.WriteLine($" Дополнительный урон 5 единиц из-за усиления \"{Player1.buffName}\".");
                }
                else
                {
                    Console.WriteLine();
                }
            }
        }

        public void Sleep(Player Player)
        {
            Console.WriteLine($"{Player.typeClass} {Player.Name} ({Player.Health} из {Player.maxHealth} hp) оглушен(-а) и пропускает ход.");
        }

        public void Winner(Player Player)
        {
            Console.WriteLine($"{Player.typeClass} {Player.Name} ({Player.Health} из {Player.maxHealth} hp) победил(-а)!");
        }

        public void Death(Player Player)
        {
            Console.WriteLine($"{Player.typeClass} {Player.Name} погибает");
        }
    }
}