namespace MonopolyKata
{
    public class Player
    {
        private readonly IBoard _board;
        private readonly IDiceService _diceService;
        
        public int ActualPosition { get; private set; }

        private readonly string _name;
        public string Name { get { return _name; } }


        public Player(IBoard board, IDiceService diceService, string name)
        {
            _board = board;
            _diceService = diceService;
            _name = name;
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