using System;
using System.Collections.Generic;
using System.Linq;

namespace MonopolyKata
{
    public interface IGame
    {
        int PlayerNumber { get; }
        IList<string> PlayerNames { get; }
        bool Running { get; }
        void Add(string playerName);
        void Start();
    }

    public class Game : IGame
    {
        private readonly IDiceService _diceService;
        private readonly IBoard _board;
        public int PlayerNumber { get { return _players.Count; } }

        private bool _running;
        public bool Running { get { return _running; } }

        private readonly IList<Player> _players;
        private Random _random;

        public IList<string> PlayerNames
        {
            get { return _players.Select(x => x.Name).ToList(); }
        }

        public Game(IDiceService diceService, IBoard board)
        {
            _diceService = diceService;
            _board = board;

            _running = false;
            _players = new List<Player>();

            _random = new Random();
        }

        public void Add(string playerName)
        {
            int index = _players.Count == 0 ? 0 : _random.Next(0, _players.Count);
            _players.Insert(index, new Player(_board, _diceService, playerName));
        }

        public void Start()
        {
            if(PlayerNumber < 2 || PlayerNumber > 8)
                _running = false;
            else
                _running = true;
        }

        
    }
}