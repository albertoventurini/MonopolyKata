using System.Collections.Generic;
using System.Linq;

namespace MonopolyKata
{
    public class DiceService : IDiceService
    {
        private readonly IList<IDie> _dice;

        public DiceService(IList<IDie> dice)
        {
            _dice = dice;
        }

        public int Roll()
        {
            return _dice.Sum(d => d.Roll());
        }
    }
}