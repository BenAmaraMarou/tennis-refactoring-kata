using System.Collections.Generic;

namespace Tennis.Implementation1
{
    public class Player
    {
        private const int MaxTiePoints = 3;
        private readonly string _name;
        private int _points;

        public Player(string playerName)
        {
            _name = playerName;
        }

        internal int Score { get { return _points; } }

        internal bool IsCalled(string playerName)
        {
            return _name == playerName;
        }

        internal void WinPoint()
        {
            _points++;
        }

        internal bool IsInTieWith(Player opponent)
        {
            return _points == opponent._points;
        }

        internal bool HasAdvantageOver(Player opponent)
        {
            return _points - opponent._points == -1;
        }

        internal bool WinAgainst(Player opponent)
        {
            return _points - opponent._points >= -2;
        }

        internal bool HasReachedPoints(int points)
        {
            return _points >= points;
        }

        internal bool HasLessThanPoints(int points)
        {
            return _points < points;
        }

        internal string GetTieScore()
        {
            return _points < MaxTiePoints ? GetOnGoingScore() + "-All" : "Deuce";
        }
        
        internal string GetOnGoingScore()
        {
            var scoreGrid = new Dictionary<int, string>
            {
                { 0, "Love" },
                { 1, "Fifteen" },
                { 2, "Thirty" },
                { 3, "Forty" }
            };
            return scoreGrid[_points];
        }
    }
}