namespace MonopolyKata
{
    public interface IGame
    {
        int PlayerNumber { get; }
    }

    public class Game : IGame
    {
        private readonly int _playerNumber;

        public Game(int playerNumber, IDiceService diceService, IBoard board)
        {
            _playerNumber = playerNumber;
        }

        public int PlayerNumber { get { return _playerNumber; }}
    }
}