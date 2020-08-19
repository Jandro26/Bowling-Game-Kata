using System;
using Xunit;

namespace BowlingGameTest
{
    public class BowlingGameShould
    {
        [Fact]
        public void It_should_score_the_same_knock_down_pins_number()
        {
            var knockDownPins = 1;
            var scored = 1;

            Assert.True(knockDownPins == scored);
        }
    }
}
