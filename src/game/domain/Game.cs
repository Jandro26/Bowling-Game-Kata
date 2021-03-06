﻿using System.Collections.Generic;
using System.Linq;

namespace BowlingGameKata.game.domain
{
    public class Game
    {
        private IList<Frame> frames;
        private Frame frame;

        public Game()
        {
            frames = new List<Frame>();
            frame = new Frame();
        }

        public void Roll(int knockPinNumber)
        {
            if (IsNewFrame())
                AddToNewFrame(knockPinNumber);
            else
                AddToExistingFrame(knockPinNumber);
        }

        private bool IsNewFrame()
        => (frame.CountRolls() == 2 || frame.CountFrameRollKnockDownPins() == 10) && frames.Count < 10;

        private void AddToNewFrame(int knockPinNumber)
        {
            frame = new Frame();
            frame.AddRoll(knockPinNumber);
            frames.Add(frame);
        }

        private void AddToExistingFrame(int knockPinNumber)
        {
            if (frames.Any())
            {
                frame = frames.Last();
                frame.AddRoll(knockPinNumber);
            }
            else
            {
                frame.AddRoll(knockPinNumber);
                frames.Add(frame);
            }
        }

        public int Score() 
        {
            var score = 0;
            Frame extraframe = null;
            foreach (var frame in frames.Reverse())
            {
                score += frame.Score(extraframe);
                extraframe = frame;
            }
            return score;
        }

    }
}
