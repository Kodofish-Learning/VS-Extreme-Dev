using NUnit.Framework;
using Should;

namespace TenisKata.Tests
{
    [TestFixture]
    public class TestClass1
    {
        [Test]
        public void Love_All()
        {
            var tennisGame = new TennisGame();
            string score = tennisGame.Score();
            score.ShouldEqual("Love All");
        }
    }

    public class TennisGame
    {
        public string Score()
        {
            throw new System.NotImplementedException();
        }
    }
}