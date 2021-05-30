using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeLadderGame
{
    class SnakeLadder
    {  /// <Single_player_at_position_0>
        public void StartGame()
        {   ///variables
            int Position = 0; 
            int PlayerOne;
           
            ///initialize player
            PlayerOne = Position;
            Console.WriteLine($"PLAYER ONE: {PlayerOne}");
            Random random = new Random();
            int DiceRoll=random.Next(1, 7); ///RandomNO_1 to 6
            Console.WriteLine("PLAYER ONE Dice Roll No.is:-" +DiceRoll);
        }
    }
    
}
