using Tennis.Implementation1;
using System;

namespace Tennis
{
    class TennisGame1 : ITennisGame
    {
        private readonly Player _player1;
        private readonly Player _player2;

        public TennisGame1(string player1Name, string player2Name)
        {
            _player1 = new Player(player1Name);
            _player2 = new Player(player2Name);
        }

        public void WonPoint(string playerName)
        {
            if (_player1.IsCalled(playerName)) _player1.WinPoint();            
            else _player2.WinPoint();
        }

        public string GetScore()
        {
            if (_player1.IsInTieWith(_player2))
            {
                return new TieState(_player1).GetScore();
            }
            else if (_player1.HasReached4Points() || _player2.HasReached4Points())
            {
                var minusResult = _player1.Score - _player2.Score;
                if (minusResult == 1) return "Advantage player1";
                else if (minusResult == -1) return "Advantage player2";
                else if (minusResult >= 2) return "Win for player1";
                else return "Win for player2";
            }
            else if(_player1.HasLessThan4Points() && _player2.HasLessThan4Points())
            {
                return _player1.GetOnGoingScore() + "-" + _player2.GetOnGoingScore();
            }

            throw new Exception("Impossible state of game");
        }
    }

    public class TieState
    {
        private readonly Player _player1;

        public TieState(Player player1)
        {
            _player1 = player1;
        }

        public string GetScore()
        {
            return _player1.GetScore();
        }
    }
}
