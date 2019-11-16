using System.Collections.Generic;

namespace Tennis.Implementation1
{
    public class Player
    {
        private readonly string _name;
        private int _score;

        public Player(string playerName)
        {
            _name = playerName;
        }

        internal int Score { get { return _score; } }

        internal bool IsCalled(string playerName)
        {
            return _name == playerName;
        }

        internal void WinPoint()
        {
            _score++;
        }

        internal bool IsInTieWith(Player opponent)
        {
            return _score == opponent._score;
        }

        internal bool HasReached4Points()
        {
            return _score >= 4;
        }

        internal bool HasLessThan4Points()
        {
            return _score < 4;
        }

        internal string GetTieScore()
        {
            return _score < 3 ? GetOnGoingScore() + "-All" : "Deuce";
        }
        
        internal string GetOnGoingScore()
        {
            var scores = new Dictionary<int, string>
            {
                { 0, "Love" },
                { 1, "Fifteen" },
                { 2, "Thirty" },
                { 3, "Forty" }
            };
            return scores[_score];
        }
    }
}