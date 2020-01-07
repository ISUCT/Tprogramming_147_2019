using System;

namespace CourseApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
             Game game = new Game();
            Console.Write("Введите число героев: ");
            
            int numOfHeroes = Int32.Parse(Console.ReadLine());

            if(numOfHeroes % 2 != 0)
            {
                numOfHeroes += 1;
            }

            game.Start(numOfHeroes);

            Console.ReadKey();
        }
    }
}
