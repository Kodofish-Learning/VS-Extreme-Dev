using System.Collections.Generic;

namespace TenisKata.Tests
{
    public class TennisGame
    {
        private int _firstPlayerScore;

        private readonly Dictionary<int, string> _score = new Dictionary<int, string>()
        {
            {2, "Thirdty" },
            {1, "Fifteen" },
            {3, "Forty" },
            {0, "Love" }
        };

        private int _secondPlayerScore;

        public string Score()
        {
            if (IsSameScore())
            {
                if (IsDeuce())
                {
                    return "Deuce";
                }
                return _score[_firstPlayerScore] + " All";
            }
            else
            {
                if (_firstPlayerScore > 0 || _secondPlayerScore > 0)
                {
                    return _score[_firstPlayerScore] + " " + _score[_secondPlayerScore];
                }
            }

            return _score[_firstPlayerScore] + " All";
        }

        private bool IsDeuce()
        {
            return _firstPlayerScore >= 3;
        }

        private bool IsSameScore()
        {
            return _firstPlayerScore == _secondPlayerScore && _firstPlayerScore > 0;
        }

        public void FirstPlayerScoreTime()
        {
            _firstPlayerScore++;
        }

        public void SecondPlayerScoreTime()
        {
            _secondPlayerScore++;
        }
    }
}