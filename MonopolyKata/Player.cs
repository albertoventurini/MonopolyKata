namespace MonopolyKata
{
    public class Player
    {
        private readonly IBoard _board;
        private readonly IDiceService _diceService;
        public int ActualPosition { get; private set; }


        public Player(IBoard board, IDiceService diceService)
        {
            _board = board;
            _diceService = diceService;
        }

        public void Advance(int delta)
        {
            ActualPosition += delta;
        }

        public void Play()
        {
            ActualPosition = _board.GetNewPosition(ActualPosition, _diceService.Roll());
        }
    }
}