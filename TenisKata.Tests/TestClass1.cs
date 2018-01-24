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
            GivenSecondPlayerScore(1);
            ShouldBe("Love Fifteen");
        }

        [Test]
        public void Love_Thirdty()
        {
            GivenSecondPlayerScore(2);
            ShouldBe("Love Thirdty");
        }

        [Test]
        public void Love_Forty()
        {
            GivenSecondPlayerScore(3);
            ShouldBe("Love Forty");
        }

        [Test]
        public void Fifteen_All()
        {
            GivenSecondPlayerScore(1);

            GivenFirstPlayerScore(1);
            ShouldBe("Love Forty");
        }

        private void GivenSecondPlayerScore(int times)
        {
            for (int i = 0; i < times; i++)
            {
                tennisGame.SecondPlayerScoreTime();
            }
        }

        private void ShouldBe(string expected)
        {
            string score = tennisGame.Score();
            score.ShouldEqual(expected);
        }
    }
}