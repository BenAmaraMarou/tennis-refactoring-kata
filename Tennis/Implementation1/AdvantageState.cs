namespace Tennis.Implementation1
{
    internal class AdvantageState : IGameState
    {
        private readonly Player _player1;
        private readonly Player _player2;

        public AdvantageState(Player player1, Player player2)
        {
            _player1 = player1;
            _player2 = player2;
        }

        public bool IsApplicable()
        {
            return _player1.HasReachedPoints(Constants.GameThresholdPoints) 
                || _player2.HasReachedPoints(Constants.GameThresholdPoints);
        }

        public string GetScore()
        {
            var minusResult = _player1.Score - _player2.Score;
            if (minusResult == 1) return "Advantage player1";
            else if (minusResult == -1) return "Advantage player2";
            else if (minusResult >= 2) return "Win for player1";
            else return "Win for player2";
        }
    }
}