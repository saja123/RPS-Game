using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPS_Game
{
    public class RPSGame
    {
        public Player player;
        public Player ai;

        public RPSGame(string name)
        {
            player = new Player(name);
            ai = new Player("AI");
        }

        public void PlayRound(string playerMove, string aiMove)
        {
            

            
            Console.WriteLine($"{ai.Name} chose {aiMove}");
            Console.WriteLine($"{player.Name} chose {playerMove}");

            if (playerMove == aiMove)
            {
                Console.WriteLine("It's a tie!");
            }
            else if ((playerMove == "rock" && aiMove == "scissors") ||
                     (playerMove == "paper" && aiMove == "rock") ||
                     (playerMove == "scissors" && aiMove == "paper"))
            {
                Console.WriteLine($"{player.Name} wins this round!");
                player.Score++;
            }
            else
            {
                Console.WriteLine($"{ai.Name} wins this round!");
                ai.Score++;
            }

            DisplayScores();
        }

        public void DisplayScores()
        {
            Console.WriteLine($"{player.Name}: {player.Score} - {ai.Name}: {ai.Score}\n ");
        }

        public void PlayGame()
        {
            while (player.Score < 3 && ai.Score < 3)
            {
                Console.Write("Choose your move: Rock, Paper, or Scissors: ");
                string playerMove = Console.ReadLine().ToLower();

                while (playerMove != "rock" && playerMove != "paper" && playerMove != "scissors")
                {
                    Console.WriteLine("Please choose from this Rock, Paper, or Scissors.");
                    playerMove = Console.ReadLine().ToLower();
                }
                string aiMove = ai.ChooseMove();
                PlayRound(playerMove, aiMove);
            }


            if (player.Score == 3)
            {
                Console.WriteLine($"{player.Name} wins the game!");
            }
            else
            {
                Console.WriteLine($"{ai.Name} wins the game!");
            }
        }
    }
}
