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
            return $"{LeadingStatus()}{_player1.GetLeader(_player2)}";
        }

        private string LeadingStatus()
        {
            return _player1.HasAdvantageOver(_player2) || _player2.HasAdvantageOver(_player1)
                ? Constants.Display.Advantage
                : Constants.Display.Win;
        }
    }
}