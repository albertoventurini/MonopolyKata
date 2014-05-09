namespace MonopolyKata
{
    public class Game
    {
        private readonly int _playerNumber;

        public Game(int playerNumber, IDiceService diceService)
        {
            _playerNumber = playerNumber;
        }

        public int PlayerNumber { get { return _playerNumber; }}
    }
}