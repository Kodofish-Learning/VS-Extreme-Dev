using System;
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

        private string _firstPlayerName;
        private readonly string _secondPlayername;

        public TennisGame(string firstPlayerName, string secondPlayername)
        {
            _firstPlayerName = firstPlayerName;
            _secondPlayername = secondPlayername;
        }

        public string Score()
        {
            return IsScoreDifferent()
                ? (IsReadForWin() ? AdvState() : NormalScore())
                : (IsDeuce() ? "Deuce" : _score[_firstPlayerScore] + " All");
        }

        private bool IsScoreDifferent()
        {
            return _firstPlayerScore != _secondPlayerScore;
        }

        private string NormalScore()
        {
            return _score[_firstPlayerScore] + " " + _score[_secondPlayerScore];
        }

        private bool IsReadForWin()
        {
            return _firstPlayerScore > 3 ||_secondPlayerScore > 3;
        }

        private string AdvState()
        {
            return AdvPlayer() + (IsAdv() ? " Adv" : " Win");
        }

        private bool IsAdv()
        {
            return Math.Abs(_firstPlayerScore-_secondPlayerScore) == 1;
        }

        private string AdvPlayer()
        {
            var advPlayer = (_firstPlayerScore > _secondPlayerScore)
                ? _firstPlayerName
                : _secondPlayername;
            return advPlayer;
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