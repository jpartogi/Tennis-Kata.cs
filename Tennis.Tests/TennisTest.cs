namespace Tennis
{
    using NUnit.Framework;
    
    public class TennisTest
    {
        private Game game;
        private const string ERIC = "Eric";
        private const string JOHN = "John";

        [SetUp]
        public void SetUp()
        {
            game = new TennisGame(ERIC, JOHN);
        }

    }
}
