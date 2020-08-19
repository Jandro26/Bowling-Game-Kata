

using System;

namespace BowlingGameKata.game.domain
{
    public class Roll
    {
        public int Score { get;}

        public Roll(int knockDownPins)
        {
            if(CheckMaxKnockDownPins(knockDownPins))
            Score = knockDownPins;
        }

        private bool CheckMaxKnockDownPins(int knockDownPins)
        {
            if (knockDownPins > 10)
                throw new Exception("Maximum number of knock down pins allowed in a roll is 10.");
            return true;
        }
    }
}
