namespace Tennis.Implementation1
{
    public interface IGameState
    {
        bool IsApplicable();
        string GetScore();
    }
}
