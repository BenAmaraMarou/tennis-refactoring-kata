using System;

namespace Tennis.Implementation1
{
    public class Player
    {
        private readonly string _name;
        private int _score;

        public Player(string player1Name)
        {
            this._name = player1Name;
        }

        public int Score { get { return _score; } }

        public bool IsCalled(string playerName)
        {
            return _name == playerName;
        }

        public void WinPoint()
        {
            _score++;
        }
    }
}
