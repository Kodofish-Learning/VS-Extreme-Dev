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
            ShouldBe("Love All");
        }

        [Test]
        public void Fifteen_Love()
        {
            tennisGame.FirstPlayerScoreTime();
            ShouldBe("Fifteen Love");
        }

        [Test]
        public void Thirdty_Love()
        {
            tennisGame.FirstPlayerScoreTime();
            tennisGame.FirstPlayerScoreTime();
            ShouldBe("Thirdty Love");
        }

        private void ShouldBe(string expected)
        {
            string score = tennisGame.Score();
            score.ShouldEqual(expected);
        }
    }
}