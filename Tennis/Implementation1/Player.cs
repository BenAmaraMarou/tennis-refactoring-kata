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

        internal bool HasLessPointsThan(int points)
        {
            return _points < points;
        }
                
        internal int Points()
        {
            return _points;
        }

        public override string ToString()
        {
            return _name;
        }
    }
}