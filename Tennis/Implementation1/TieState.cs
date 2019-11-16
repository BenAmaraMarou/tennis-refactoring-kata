namespace Tennis.Implementation1
{
    public class TieState : IGameState
    {
        private readonly Player _player1;
        private readonly Player _player2;

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
            return _player1.GetTieScore().Display();
        }
    }
}
