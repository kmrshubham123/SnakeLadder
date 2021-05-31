using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeLadderGame
{
    class SnakeLadder
    { 
      
           ///variables
        public int Position = 0;
        const int Ladder = 1;
        const int Snake = 2;
          public void StartGame()
          {
              Random dice = new Random();
              int DiceRoller = dice.Next(1, 7);
              Console.WriteLine("Player rolls the die and gets :- " + DiceRoller);
              int SnakeandLadder = dice.Next(0, 3);

                switch (SnakeandLadder)
                {
                    case Ladder:
                        Position += DiceRoller;
                    Console.WriteLine("WOW! LADDER");
                        break;

                    case Snake:
                        Position -= DiceRoller;
                    Console.WriteLine("OH NO! ___Snake Bite");
                        break;

                    default:
                    Console.WriteLine("No Play");
                        break;
                }
          }
        

    }
}
