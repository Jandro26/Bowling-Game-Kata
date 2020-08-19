using BowlingGameKata.game.domain;
using Xunit;

namespace BowlingGameTest
{
    public class BowlingGameShould
    {

        private readonly Game game;

        public BowlingGameShould()
        {
            game = new Game();
        }

        [Fact]
        public void It_should_score_the_number_of_knock_down_pins()
        {
            var expectedScore = 14;
            CreateFrame(6, 8);
            var score = game.Score();
            Assert.True(score == expectedScore);
        }

        [Fact]
        public void It_should_score_an_spare_in_a_frame()
        {
            var expectedScore = 23;
            CreateFrame(6, 4);
            CreateFrame(4, 5);
            var score = game.Score();
            Assert.True(score == expectedScore);
        }

        [Fact]
        public void It_should_score_an_strike_in_a_frame()
        {
            var expectedScore = 18;
            CreateFrame(10, null);
            CreateFrame(4, 0);
            var score = game.Score();
            Assert.True(score == expectedScore);
        }

        [Fact]
        public void It_should_score_a_ten_frames_game()
        {
            var expectedScore = 50;
            CreateFrame(8, 2);
            CreateFrame(4, 0);
            CreateFrame(4, 0);
            CreateFrame(4, 0);
            CreateFrame(4, 0);
            CreateFrame(4, 0);
            CreateFrame(4, 0);
            CreateFrame(4, 0);
            CreateFrame(4, 0);
            CreateFrame(4, 0);
            var score = game.Score();
            Assert.True(score == expectedScore);
        }

        [Fact]
        public void It_should_score_with_and_spare_in_the_last_roll()
        {
            var expectedScore = 62;
            CreateFrame(8, 2);
            CreateFrame(4, 0);
            CreateFrame(4, 0);
            CreateFrame(4, 0);
            CreateFrame(4, 0);
            CreateFrame(4, 0);
            CreateFrame(4, 0);
            CreateFrame(4, 0);
            CreateFrame(4, 0);
            CreateFrame(4, 6);
            game.Roll(6);
            var score = game.Score();
            Assert.True(score == expectedScore);
        }

        [Fact]
        public void It_should_score_with_and_strike_in_the_last_roll()
        {
            var expectedScore = 62;
            CreateFrame(8, 2);
            CreateFrame(4, 0);
            CreateFrame(4, 0);
            CreateFrame(4, 0);
            CreateFrame(4, 0);
            CreateFrame(4, 0);
            CreateFrame(4, 0);
            CreateFrame(4, 0);
            CreateFrame(4, 0);
            CreateFrame(10, null);
            game.Roll(6);
            var score = game.Score();
            Assert.True(score == expectedScore);
        }

        private void CreateFrame(int firstRoll, int? secondRoll)
        {
            game.Roll(firstRoll);
            if (secondRoll != null)
                game.Roll(secondRoll.Value);
        }
    }
}
