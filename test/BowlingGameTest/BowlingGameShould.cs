using BowlingGameKata.game.domain;
using Xunit;

namespace BowlingGameTest
{
    public class BowlingGameShould
    {
        [Fact]
        public void It_should_score_the_number_of_knock_down_pins()
        {
            var expectedScore = 14;
            var game = new Game();
            game.Roll(6);
            game.Roll(8);
            var score = game.Score();
            Assert.True(score == expectedScore);
        }
    }
}
