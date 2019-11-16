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
            var onGoingState = new OnGoingState(_player1, _player2);
            if (tieState.IsApplicable())
            {
                return tieState.GetScore();
            }
            else if (advantageState.IsApplicable())
            {
                return advantageState.GetScore();
            }
            else if(onGoingState.IsApplicable())
            {
                return onGoingState.GetScore();
            }

            throw new Exception("Impossible state of game");
        }
    }
}
