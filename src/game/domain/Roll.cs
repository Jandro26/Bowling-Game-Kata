

using System;

namespace BowlingGameKata.game.domain
{
    public class Roll
    {
        private const int MAX_KNOCKDOWN_PINS_NUMBER = 10;
        public int Score { get;}

        public Roll(int knockDownPins)
        {
            if(CheckMaxKnockDownPins(knockDownPins))
                Score = knockDownPins;
        }

        private bool CheckMaxKnockDownPins(int knockDownPins)
        {
            if (knockDownPins > MAX_KNOCKDOWN_PINS_NUMBER)
                throw new Exception($"Maximum number of knock down pins allowed in a roll is {MAX_KNOCKDOWN_PINS_NUMBER}.");
            return true;
        }
    }
}
