namespace Tennis.Implementation1
{
    internal class OnGoingState
    {
        private readonly Player _player1;
        private readonly Player _player2;

        public OnGoingState(Player player1, Player player2)
        {
            _player1 = player1;
            _player2 = player2;
        }

        internal bool IsApplicable()
        {
            return _player1.HasLessThan4Points() && _player2.HasLessThan4Points();
        }

        internal string GetScore()
        {
            return _player1.GetOnGoingScore() + "-" + _player2.GetOnGoingScore();
        }
    }
}