using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace RPS_Game
{
    public class Player
    {
        public string Name { get; set; }

        public int Score { get; set; }

        public Player(string name)
        {
            Name = name;
            Score = 0;
        }

        public string ChooseMove()
        {
            string[] moves = { "rock", "paper", "scissors" };
            Random random = new Random();
            return moves[random.Next(0, moves.Length)];
        }
    }
}
