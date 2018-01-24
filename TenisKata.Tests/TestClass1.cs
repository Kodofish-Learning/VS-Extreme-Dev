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
            GivenFirstPlayerScore(1);
            ShouldBe("Fifteen Love");
        }

        private void GivenFirstPlayerScore(int times)
        {
            for (int i = 0; i < times; i++)
            {
                tennisGame.FirstPlayerScoreTime();
            }
        }

        [Test]
        public void Thirdty_Love()
        {
            GivenFirstPlayerScore(2);
            ShouldBe("Thirdty Love");
        }

        [Test]
        public void Forty_Love()
        {
            GivenFirstPlayerScore(3);
            ShouldBe("Forty Love");
        }

        [Test]
        public void Love_Fifteen()
        {
            GivenFirstPlayerScore(1);
            ShouldBe("Love Fifteen");
        }

        private void ShouldBe(string expected)
        {
            string score = tennisGame.Score();
            score.ShouldEqual(expected);
        }
    }
}