using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeLadderGame
{
    class SnakeLadder
    {
        public int Position = 0;
        const int Ladder = 1;
        const int Snake = 2;
        public void StartGame()
        {
            Random dice = new Random();

            while (Position != 100)
            {
                int DiceRoller = dice.Next(1, 7);
                Console.WriteLine("Player rolls the die and gets :- " + DiceRoller);
                int SnakeOrLadder = dice.Next(0, 3);
                switch (SnakeOrLadder)
                {
                    case Ladder:
                        Console.WriteLine("WOW! Ladder");
                        if (Position + DiceRoller <= 100)
                            Position += DiceRoller;
                        else
                            Position = Position + 0;
                        Position += DiceRoller;
                        break;
                    case Snake:
                        Console.WriteLine("ohh No!-----@Snake Bite");
                        Position -= DiceRoller;
                        if (Position < 0)
                         Position = 0;
                        break;
                    default:
                        Console.WriteLine("No Play");
                        break;
                }
                Console.WriteLine("Current position : " + Position);
            }
            Console.WriteLine("Winning position : " + Position);
        }
    }
}
