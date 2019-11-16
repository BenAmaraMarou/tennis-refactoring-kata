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
            var tieState = new TieState(_player1, _player2);
            var advantageState = new AdvantageState(_player1, _player2);
            if (tieState.IsApplicable())
            {
                return tieState.GetScore();
            }
            else if (advantageState.IsApplicable())
            {
                return advantageState.GetScore();
            }
            else if(_player1.HasLessThan4Points() && _player2.HasLessThan4Points())
            {
                return _player1.GetOnGoingScore() + "-" + _player2.GetOnGoingScore();
            }

            throw new Exception("Impossible state of game");
        }
    }
}
