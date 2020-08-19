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

        [Fact]
        public void It_should_score_an_spare_in_a_frame()
        {
            var expectedScore = 14;
            var game = new Game();
            game.Roll(6);
            game.Roll(4);
            game.Roll(4);
            var score = game.Score();
            Assert.True(score == expectedScore);
        }

        [Fact]
        public void It_should_score_an_strike_in_a_frame()
        {
            var expectedScore = 14;
            var game = new Game();
            game.Roll(8);
            game.Roll(2);
            game.Roll(4);
            game.Roll(0);
            var score = game.Score();
            Assert.True(score == expectedScore);
        }

    }
}
