using Microsoft.VisualStudio.TestTools.UnitTesting;
using _106_otro;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

            Scorecard scorecard = new Scorecard();
            scorecard.Add("Player1", 10);
            scorecard.Add("Player2", 15);
            int expectedScore = 15;
            int actualScore = scorecard["Player2"];
            Assert.AreEqual(expectedScore, actualScore);
        }
    }
}
