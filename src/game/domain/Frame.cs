using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BowlingGameKata.game.domain
{
    public class Frame
    {
        private IList<Roll> rolls;

        public Frame()
        {
            rolls = new List<Roll>();
        }

        public void AddRoll(int knockDownPins)
        {
            var roll = new Roll();
            roll.Score = knockDownPins;
            rolls.Add(roll);
        }

        public int Score()
        {
            var score = 0;
            foreach (var roll in rolls)
            {
                score += roll.Score;
            }
            return score;
        }
    }
}
