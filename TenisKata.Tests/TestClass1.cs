using NUnit.Framework;
using Should;

namespace TenisKata.Tests
{
    [TestFixture]
    public class TestClass1
    {
        private TennisGame tennisGame;

        [SetUp]
        public void Setup()
        {
            tennisGame = new TennisGame();
        }

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

        [Test]
        public void Thirdty_Love()
        {
            tennisGame.FirstPlayerScoreTime();
            tennisGame.FirstPlayerScoreTime();
            string score = tennisGame.Score();
            score.ShouldEqual("Thirdty Love");
        }
    }
}