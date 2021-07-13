using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Q107;
namespace UnitTesting
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void UnitTest1()
        {
            ScoreCard scoreCard = new ScoreCard();
            scoreCard.Add("Player1", 10);
            scoreCard.Add("Player2", 15);
            int expectedScore = 15;
            int actualScore = scoreCard["Player2"];
            Assert.AreEqual(expectedScore, actualScore);
        }
    }
}

