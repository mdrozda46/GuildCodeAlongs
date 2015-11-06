using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithConstructorsAndPartials
{
    public class GameWorkflow
    {
        public Player player1;
        public Player player2;

        private static Random _randomKey;

        static GameWorkflow()
        {
            _randomKey = new Random();
        }

        private int RollDice()
        {
           return _randomKey.Next(1, 7);
        }

        public void PlayGame()
        {
            player1.score = 0;
            player2.score = 0;

            while (player1.score < 100 && player2.score < 100)
            {
                player1.score += RollDice();
                player2.score += RollDice();
            }

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n************GAME OVER************");
            Console.WriteLine("{0}: {1}  vs  {2}: {3}", player1.Name, player1.score, player2.Name, player2.score);
        }
    }
}
