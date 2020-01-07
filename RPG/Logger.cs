using System;

namespace RPG
{
    class Logger
    {
        public void Atack(Player Player1, Player Player2, int damage)
        {
            if (Player1.typeClass == "Рыцарь")
            {
                Console.Write($"{Player1.typeClass} {Player1.Name} ({Player1.Health} / {Player1.maxHealth}) ударил мечом {Player2.typeClass} {Player2.Name} ({Player2.Health} / {Player2.maxHealth}) и нанёс {damage} урона.");
            }
            else if (Player1.typeClass == "Лучник")
            {
                Console.Write($"{Player1.typeClass} {Player1.Name} ({Player1.Health} / {Player1.maxHealth}) выстрелил в {Player2.typeClass} {Player2.Name} ({Player2.Health} / {Player2.maxHealth}) и нанёс {damage} урона.");
            }
            else
            {
                Console.Write($"{Player1.typeClass} {Player1.Name} ({Player1.Health} / {Player1.maxHealth}) ударил посохом {Player2.typeClass} {Player2.Name} ({Player2.Health} / {Player2.maxHealth}) и нанёс {damage} урона.");
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
                Console.WriteLine($"{Player1.typeClass} {Player1.Name} ({Player1.Health} / {Player1.maxHealth}) использует умение \"{skillName}\" и оглушает {Player2.typeClass} {Player2.Name} ({Player2.Health} / {Player2.maxHealth}) на {Player1.sleepTime} хода.");
            }
            else if (Player1.sleepTime > 1)
            {
                Console.WriteLine($"{Player1.typeClass} {Player1.Name} ({Player1.Health} / {Player1.maxHealth}) использовал(-a) умение \"{skillName}\" и нанес(-ла) {Player2.typeClass} {Player2.Name} {damage} урона. {Player2.typeClass} {Player2.Name} ({Player2.Health} / {Player2.maxHealth}) оглушен(-а) на {Player1.sleepTime} ход(-а).");
            }
            else if (Player1.buff && damage == 0)
            {
                Console.WriteLine($"{Player1.typeClass} {Player1.Name} ({Player1.Health} / {Player1.maxHealth}) активировал усиление \"{skillName}\"");
            }
            else
            {
                Console.Write($"{Player1.typeClass} {Player1.Name} ({Player1.Health} / {Player1.maxHealth}) использовал(-a) умение \"{skillName}\" и нанес(-ла) {Player2.typeClass} {Player2.Name} ({Player2.Health} / {Player2.maxHealth}) {damage} урона.");

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
            Console.WriteLine($"{Player.typeClass} {Player.Name} ({Player.Health} / {Player.maxHealth}) оглушен(-а) и пропускает ход.");
        }

        public void Winner(Player Player)
        {
            Console.WriteLine($"{Player.typeClass} {Player.Name} ({Player.Health} / {Player.maxHealth}) победил(-а)!");
        }

        public void Death(Player Player)
        {
            Console.WriteLine($"{Player.typeClass} {Player.Name} погибает");
        }
    }
}