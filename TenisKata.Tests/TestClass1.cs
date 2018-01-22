using NUnit.Framework;
using Should;

namespace TenisKata.Tests
{
    [TestFixture]
    public class TestClass1
    {
        private TennisGame tennisGame = new TennisGame();

        [Test]
        public void Love_All()
        {
            string score = tennisGame.Score();
            score.ShouldEqual("Love All");
        }

        [Test]
        public void Fifteen_Love()
        {
            tennisGame.FirstPlayerScoreTime();
            string score = tennisGame.Score();
            score.ShouldEqual("Fifteen Love");
        }
    }
}