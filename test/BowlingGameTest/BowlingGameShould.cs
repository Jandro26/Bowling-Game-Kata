using BowlingGameKata.game.domain;
using System;
using Xunit;

namespace BowlingGameTest
{
    public class BowlingGameShould
    {
        [Fact]
        public void It_should_score_the_number_of_knock_down_pins()
        {
            var knockDownPins = 5;
            var expectedScore = 5;
            var game = new Game();
            game.Roll(knockDownPins);
            var score = game.Score();
            Assert.True(score == expectedScore);
        }
    }
}
