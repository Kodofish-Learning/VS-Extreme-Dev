namespace TenisKata.Tests
{
    public class TennisGame
    {
        private int _firstPlayerScore;

        public string Score()
        {
            if (_firstPlayerScore == 1)
            {
                return "Fifteen Love";
            }
            return "Love All";
        }

        public void FirstPlayerScoreTime()
        {
            _firstPlayerScore++;
        }
    }
}