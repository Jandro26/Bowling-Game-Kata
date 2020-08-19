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
            rolls.Add(new Roll(knockDownPins));
        }

        public int CountRolls()
        => rolls.Count();

        public int CountFirstRollKnockDownPins()
        => rolls[0].Score;

        public int CountFrameRollKnockDownPins()
        => rolls.Sum(r => r.Score);

        public int Score(Frame frame)
        {
            if(frame == null) return CountFrameRollKnockDownPins();
            var score = 0;
            foreach (var roll in rolls)
            {   
                score += roll.Score;
                if (roll.Score == 10)
                    score += frame.CountFrameRollKnockDownPins();
            }
            if (CountFirstRollKnockDownPins()<10 && CountFrameRollKnockDownPins() == 10)
                score += frame.CountFirstRollKnockDownPins();

            return score;
        }
    }
}
