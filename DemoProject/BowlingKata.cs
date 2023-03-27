using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject
{
    [TestClass]
    public class BowlingKata
    {
        Game? game;

        private void RollMany(int rolls, int pins)
        {
            for (int roll = 0; roll < rolls; roll++)
            {
                game!.Roll(pins);
            }
        }

        private void RollSpare()
        {
            game!.Roll(5);
            game!.Roll(5);
        }

        private void RollStrike()
        {
            game!.Roll(10);
        }

        [TestInitialize]
        public void Init()
        {
            game = new Game();
        }

        [TestMethod]
        public void GutterBallGame()
        {
            RollMany(20, 0);

            Assert.AreEqual(0, game!.Score());
        }

        [TestMethod]
        public void OnePinGame()
        {
            game!.Roll(1);
            RollMany(19, 0);

            Assert.AreEqual(1, game!.Score());
        }

        //[Ignore]
        [TestMethod]
        public void OneSpareGame()
        {
            RollSpare();
            game!.Roll(3);
            RollMany(17, 0);

            Assert.AreEqual(16, game!.Score());
        }



        [TestMethod]
        public void OneStrikeGame()
        {
            RollStrike();
            game!.Roll(3);
            game!.Roll(4);
            RollMany(16, 0);

            Assert.AreEqual(24, game!.Score());
        }



        [TestMethod]
        public void PerfectGame()
        {
            RollMany(12, 10);
            Assert.AreEqual(300, game!.Score());
        }

    }

    public class Game
    {
        private int[] rolls = new int[21];
        private int currentRoll = 0;
        public Game()
        {
        }

        public void Roll(int pins)
        {
            rolls[currentRoll] = pins;
            currentRoll++;
        }

        public int Score()
        {
            int score = 0;
            int rollCounter = 0;
            for (var frame = 0; frame < 10; frame++)
            {
                if (IsStrike(rollCounter))
                {
                    score += 10 + RollsInNextFrame(rollCounter);
                    rollCounter++;
                }
                else
                {
                    if (IsSpare(rollCounter))
                    {
                        score += 10 + rolls[rollCounter + 2];
                    }
                    else
                    {
                        score += RollsInFrame(rollCounter);
                    }

                    rollCounter += 2;
                }
            }
            return score;
        }

        private int RollsInNextFrame(int rollCounter)
        {
            return rolls[rollCounter + 1] + rolls[rollCounter + 2];
        }

        private bool IsSpare(int rollCounter)
        {
            return RollsInFrame(rollCounter) == 10;
        }

        private bool IsStrike(int rollCounter)
        {
            return rolls[rollCounter] == 10;
        }

        private int RollsInFrame(int rollCounter)
        {
            return rolls[rollCounter] + rolls[rollCounter + 1];
        }
    }
}