namespace Tennis.Implementation1
{
    internal class LeadingState : IGameState
    {
        private readonly Player _player1;
        private readonly Player _player2;

        public LeadingState(Player player1, Player player2)
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
            if (IsAnyPlayerInAdvantage()) return "Advantage " + PlayerInAdvantage();
            return "Win for " + WinningPlayer();
        }

        private bool IsAnyPlayerInAdvantage()
        {
            return _player1.HasAdvantageOver(_player2) || _player2.HasAdvantageOver(_player1);
        }

        private Player PlayerInAdvantage()
        {
            return _player1.HasAdvantageOver(_player2) ? _player1 : _player2;
        }

        private Player WinningPlayer()
        {
            return _player1.WinAgainst(_player2) ? _player1 : _player2;
        }
    }
}