namespace Tennis.Implementation1
{
    public class Player
    {
        private readonly string _name;
        private int _score;

        public Player(string player1Name)
        {
            this._name = player1Name;
        }

        internal int Score { get { return _score; } }

        internal bool IsCalled(string playerName)
        {
            return _name == playerName;
        }

        internal void WinPoint()
        {
            _score++;
        }

        internal bool IsInTieWith(Player player2)
        {
            return _score == player2._score;
        }
    }
}
