using System.Collections.Generic;

namespace Tennis.Implementation1
{
    public class TieState : IGameState
    {
        private readonly Player _player1;
        private readonly Player _player2;
        private static readonly IReadOnlyDictionary<int, TieScore> ScoreGrid = new Dictionary<int, TieScore>
        {
            { 0, TieScore.LoveAll },
            { 1, TieScore.FifteenAll },
            { 2, TieScore.ThirtyAll }
        };

        public TieState(Player player1, Player player2)
        {
            _player1 = player1;
            _player2 = player2;
        }

        public bool IsApplicable()
        {
            return _player1.IsInTieWith(_player2);
        }

        public string GetScore()
        {
            if (!ScoreGrid.TryGetValue(_player1.Points(), out TieScore score)) score = TieScore.Deuce;
            return score.Display();
        }
    }
}