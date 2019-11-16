using System.Collections.Generic;

namespace Tennis.Implementation1
{
    internal class OnGoingState : IGameState
    {
        private readonly Player _player1;
        private readonly Player _player2;
        private static readonly IReadOnlyDictionary<int, OnGoingScore> ScoreGrid = new Dictionary<int, OnGoingScore>
            {
                { 0, OnGoingScore.Love },
                { 1, OnGoingScore.Fifteen },
                { 2, OnGoingScore.Thirty },
                { 3, OnGoingScore.Forty }
            };

        public OnGoingState(Player player1, Player player2)
        {
            _player1 = player1;
            _player2 = player2;
        }

        public bool IsApplicable()
        {
            return _player1.HasLessPointsThan(Constants.GameThresholdPoints)
                && _player2.HasLessPointsThan(Constants.GameThresholdPoints);
        }

        public string GetScore()
        {
            return $"{ScoreGrid[_player1.Points()].Display()} - {ScoreGrid[_player2.Points()].Display()}";
        }
    }
}