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

        internal int Score { get { return _score; } }

        internal bool IsCalled(string playerName)
        {
            return _name == playerName;
        }

        internal void WinPoint()
        {
            _score++;
        }

        internal bool IsInTieWith(Player player2)
        {
            return _score == player2._score;
        }

        internal string GetScore()
        {
            string score;
            switch (_score)
            {
                case 0:
                    score = "Love-All";
                    break;
                case 1:
                    score = "Fifteen-All";
                    break;
                case 2:
                    score = "Thirty-All";
                    break;
                default:
                    score = "Deuce";
                    break;
            }
            return score;
        }

        internal bool HasReached4Points()
        {
            return _score >= 4;
        }

        internal string GetOnGoingScore()
        {
            string score;
            switch (_score)
            {
                case 0:
                    score = "Love";
                    break;
                case 1:
                    score = "Fifteen";
                    break;
                case 2:
                    score = "Thirty";
                    break;
                case 3:
                    score = "Forty";
                    break;
                default:
                    score = null;
                    break;
            }
            return score;
        }
    }
}
