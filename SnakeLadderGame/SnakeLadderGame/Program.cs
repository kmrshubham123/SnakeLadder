using System;

namespace SnakeLadderGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=======> WELCOME TO THE SNAKE AND LADDER GAME <=======");
            SnakeLadder snakeLadder = new SnakeLadder();
            snakeLadder.StartGame();
        }
    }
}
