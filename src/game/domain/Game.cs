using System.Collections.Generic;

namespace BowlingGameKata.game.domain
{
    public class Game
    {
        private IList<Frame> frames;
        private Frame frame;

        public Game()
        {
            frames = new List<Frame>();
        }

        public void Roll(int knockPinNumber)
        {
            frame = new Frame();
            frame.AddRoll(knockPinNumber);
            frames.Add(frame);
        }

        public int Score() 
        {
            var score = 0;
            foreach (var frame in frames)
            {
                score += frame.Score();
            }
            return score;
        }
    }
}
