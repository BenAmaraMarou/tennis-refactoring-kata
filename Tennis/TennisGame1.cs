using Tennis.Implementation1;
using System.Collections.Generic;
using System.Linq;

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
            var gameStates = GetGameStates();
            return gameStates.First(state => state.IsApplicable()).GetScore();
        }

        private IEnumerable<IGameState> GetGameStates()
        {
            return new IGameState[3]
            {
                new TieState(_player1, _player2),
                new AdvantageState(_player1, _player2),
                new OnGoingState(_player1, _player2)
            };
        }
    }
}
