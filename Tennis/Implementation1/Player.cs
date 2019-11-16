using System.Collections.Generic;

namespace Tennis.Implementation1
{
    public class Player
    {
        private readonly string _name;
        private int _points;

        public Player(string playerName)
        {
            _name = playerName;
        }

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
            return _points - opponent._points == 1;
        }

        internal bool WinAgainst(Player opponent)
        {
            return _points - opponent._points >= 2;
        }

        internal bool HasReachedPoints(int points)
        {
            return _points >= points;
        }

        internal bool HasLessThanPoints(int points)
        {
            return _points < points;
        }

        internal TieScore GetTieScore()
        {
            var scoreGrid = new Dictionary<int, TieScore>
            {
                { 0, TieScore.LoveAll },
                { 1, TieScore.FifteenAll },
                { 2, TieScore.ThirtyAll }
            };
            return scoreGrid.TryGetValue(_points, out TieScore score) ? score : TieScore.Deuce;
        }
        
        internal OnGoingScore GetOnGoingScore()
        {
            var scoreGrid = new Dictionary<int, OnGoingScore>
            {
                { 0, OnGoingScore.Love },
                { 1, OnGoingScore.Fifteen },
                { 2, OnGoingScore.Thirty },
                { 3, OnGoingScore.Forty }
            };
            return scoreGrid[_points];
        }

        public override string ToString()
        {
            return _name;
        }
    }
}