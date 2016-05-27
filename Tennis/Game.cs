namespace Tennis
{
    public interface Game
    {
        void WonPoint(string playerName);
        string GetScore();
    }
}