using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BowlingGameKata.game.domain
{
    public class Game
    {
        private int score;

        public Game()
        {
            score = 0;
        }

        public void Roll(int knockPinNumber)
        {
            score += knockPinNumber;
        }

        public int Score() 
        {
            return score;
        }
    }
}
