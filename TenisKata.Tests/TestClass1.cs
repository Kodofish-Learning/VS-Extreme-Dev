using NUnit.Framework;
using Should;

namespace TenisKata.Tests
{
    [TestFixture]
    public class TestClass1
    {
        private TennisGame _tennisGame;

        [SetUp]
        public void Setup()
        {
            _tennisGame = new TennisGame("Joey", "Fish");
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
                _tennisGame.FirstPlayerScoreTime();
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
            ShouldBe("Fifteen All");
        }

        [Test]
        public void Deuce()
        {
            GivenSecondPlayerScore(3);

            GivenFirstPlayerScore(3);
            ShouldBe("Deuce");
        }

        [Test]
        public void FirstPlayer_Advantage()
        {
            GivenFirstPlayerScore(4);
            GivenSecondPlayerScore(3);
            ShouldBe("Joey Adv");
        }

        [Test]
        public void SecondPlayer_advantage()
        {
            GivenFirstPlayerScore(3);
            GivenSecondPlayerScore(4);
            ShouldBe("Fish Adv");
        }
        [Test]
        public void Fish_Adv()
        {
            GivenSecondPlayerScore(4);

            GivenFirstPlayerScore(3);
            ShouldBe("Fish Adv");
        }

        [Test]
        public void SecondPlayerWin()
        {
            GivenSecondPlayerScore(5);

            GivenFirstPlayerScore(3);
            ShouldBe("Fish Win");
        }

        [Test]
        public void FirstPlayerWin()
        {
            GivenSecondPlayerScore(3);

            GivenFirstPlayerScore(5);
            ShouldBe("Joey Win");
        }

        private void GivenSecondPlayerScore(int times)
        {
            for (int i = 0; i < times; i++)
            {
                _tennisGame.SecondPlayerScoreTime();
            }
        }

        private void ShouldBe(string expected)
        {
            string score = _tennisGame.Score();
            score.ShouldEqual(expected);
        }
    }
}