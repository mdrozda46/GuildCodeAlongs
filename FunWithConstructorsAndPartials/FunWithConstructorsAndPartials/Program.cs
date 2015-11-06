using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithConstructorsAndPartials
{
    class Program
    {
        static void Main(string[] args)
        {

            Player p1 = new Player("Player 1");
            Player p2 = new Player();
            string keepPlaying = "n";

            while (keepPlaying == "n")
            {
                GameWorkflow game = new GameWorkflow();

                game.player1 = p1;
                game.player2 = p2;

                game.PlayGame();

                Console.WriteLine("\nEnter n to start a new game, enter q to quit:");
                keepPlaying = Console.ReadLine();
            }

            Console.WriteLine("\n\nDone playing! Press a key to close the board.");
            Console.ReadLine();

        }
    }
}
