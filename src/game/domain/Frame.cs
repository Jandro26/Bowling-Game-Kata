using System.Collections.Generic;
using System.Linq;

namespace BowlingGameKata.game.domain
{
    public class Frame
    {
        private IList<Roll> rolls;
        private const int MAX_KNOCKDOWN_PINS_NUMBER = 10;

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
            if (frame == null) return CountFrameRollKnockDownPins();
            return CalculateScore(frame);        
        }

        private int CalculateScore(Frame frame)
        {
            var score = 0;
            foreach (var roll in rolls)
            {
                score += roll.Score;
                if (roll.Score == MAX_KNOCKDOWN_PINS_NUMBER)
                    score += frame.CountFrameRollKnockDownPins();
            }
            if (IsSpareFrame())
                score += frame.CountFirstRollKnockDownPins();

            return score;
        }

        private bool IsSpareFrame()
            => CountFirstRollKnockDownPins() < MAX_KNOCKDOWN_PINS_NUMBER && CountFrameRollKnockDownPins() == MAX_KNOCKDOWN_PINS_NUMBER;
    }
}
