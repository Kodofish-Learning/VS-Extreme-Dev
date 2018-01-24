using System.Collections.Generic;

namespace TenisKata.Tests
{
    public class TennisGame
    {
        private int _firstPlayerScore;

        private Dictionary<int, string> score = new Dictionary<int, string>()
        {
            {2, "Thirdty" },
            {1, "Fifteen" }
        };

        public string Score()
        {
            if (_firstPlayerScore > 0)
            {
                return score[_firstPlayerScore] + " Love";
            }
            return "Love All";
        }

        public void FirstPlayerScoreTime()
        {
            _firstPlayerScore++;
        }
    }
}