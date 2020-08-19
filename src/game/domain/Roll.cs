

namespace BowlingGameKata.game.domain
{
    public class Roll
    {
        public int Score { get;}

        public Roll(int knockDownPins)
        {
            Score = knockDownPins;
        }
    }
}
