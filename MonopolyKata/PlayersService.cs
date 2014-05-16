using System.Collections.Generic;
using System.Linq;

namespace MonopolyKata
{
    public class PlayersService
    {
        private IList<Player> _playerList;

        public void Create(int playerNumber)
        {
            _playerList = new Player[playerNumber].ToList();
        }

        public int PlayerNumber { get { return _playerList.Count(); }  }
    }

    
}